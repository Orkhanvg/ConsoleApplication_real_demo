using DataAccess;
using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;

namespace Business.Repositories
{
    public class GroupRepository:IRepository<Group>
    {
        public bool Create(Group entity)
        {
            try
            {
                DataContext.Groups.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Group entity)
        {
            try
            {
                DataContext.Groups.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Group> GetAll(Predicate<Group> Filter = null)
        {
            try
            {
                return DataContext.Groups.FindAll(Filter);


            }
            catch (Exception)
            {

                throw;
            }
        }

        public Group GetOne(Predicate<Group> Filter = null)
        {
            try
            {
                return Filter == null ? DataContext.Groups[0] :
                    DataContext.Groups.Find(Filter);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Group entity)
        {
            try
            {
                Group isExsist = GetOne(s => s.Id == entity.Id);
                isExsist = entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
