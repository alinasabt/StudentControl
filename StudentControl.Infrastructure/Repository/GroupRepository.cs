﻿using StudentControl.Domain.Model;
using StudentControl.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentControl.Infrastructure.Repository
{
    public class GroupRepository
    {
        private readonly Context context;

        public Context UnitOfWork { get { return context; } }

        public GroupRepository(Context context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));

        }

        public void ChangeTrackerClear()
        {
            context.ChangeTracker.Clear();
        }

        public async Task AddAsync(Group group)
        {
            context.Groups.Add(group);
            await context.SaveChangesAsync();
        }

        public async Task<List<Group>> GetAllAsync()
        {
            return await context.Groups.OrderBy(p => p.Name).ToListAsync();
        }

        public async Task<Group?> GetByIdAsync(Guid id)
        {
            return await context.Groups.Where(p => p.Id == id)
                .Include(p => p.Students)
                .FirstOrDefaultAsync();
        }


        public async Task<Group?> GetByNameAsync(string name)
        {
            return await context.Groups
                .Where(p => p.Name == name)
                .Include(p => p.Students)
                .FirstOrDefaultAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            Group? group = await context.Groups.FindAsync(id);

            if (group != null)
            {
                context.Remove(group);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(Group ChangedGroup)
        {
            var existGroup = GetByIdAsync(ChangedGroup.Id).Result;
            if (existGroup != null)
            {
                context.Entry(existGroup).CurrentValues.SetValues(ChangedGroup);
                //Удаление студентов что не входят в новый список
                foreach (var existStudent in existGroup.Students.ToList())
                {
                    if (!ChangedGroup.Students.Any(ord => ord.Id == existStudent.Id))
                    {
                        existStudent.Group = null;
                        existGroup.RemoveStudent(existStudent);
                    }
                }

                //Добавление новых или изменение существующих студентов
                foreach (var NewOrder in ChangedGroup.Students)
                {
                    var existOrder = existGroup.Students.FirstOrDefault(ord => ord.Id == NewOrder.Id);

                    if (existOrder != null)
                    {
                        context.Entry(existOrder).CurrentValues.SetValues(NewOrder);

                    }
                    else
                    {
                        existGroup.Students.Add(NewOrder);
                    }

                    await context.SaveChangesAsync();

                }
            }
        }
    }
}
