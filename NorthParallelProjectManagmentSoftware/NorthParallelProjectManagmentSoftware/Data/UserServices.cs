using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NorthParallelProjectManagmentSoftware.Data
{
    public class UserServices
    {
        private readonly ApplicationDbContext _appDBContext;

        public UserServices(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        //Get list of all users
        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _appDBContext.User.ToListAsync();
        }

        //Add new user
        public async Task<bool> InsertUserAsync(User user)
        {
            await _appDBContext.User.AddAsync(user);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        //Get User by UserId
        public async Task<User> GetUserAsync(int Id)
        {
            User user = await _appDBContext.User.FirstOrDefaultAsync(c => c.UserId.Equals(Id));
            return user;
        }

        public async Task<List<User>> GetUserByProject(string project)
        {
            List<User> userByProject = new List<User>();
            List<User> user = await _appDBContext.User.ToListAsync();
            foreach (var users in user)
            {

                if (users.UserAssignedProjects.ProjectName.ToString() == project)
                {
                
                    userByProject.Add(users);
                }
                



            }

            return userByProject.ToList();
        }
       

        //Update user
        public async Task<bool> UpdateUserAsync(User user)
        {
            _appDBContext.User.Update(user);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        //Delete user
        public async Task<bool> DeleteUserAsync(User user)
        {
            _appDBContext.User.Remove(user);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<User>> GetUserMCompanyAsync(string mCompany)
        {
            List<User> userByMain = new List<User>();
            List<User> user = await _appDBContext.User.ToListAsync();
            foreach (var usr in user)
            {

                if (usr.MainCompany == mCompany)
                {

                    userByMain.Add(usr);
                }

            }

            return userByMain;

        }
    }
}
