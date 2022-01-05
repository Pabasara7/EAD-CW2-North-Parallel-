using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NorthParallelProjectManagmentSoftware.Data
{
    public class TicketServices
    {
        private readonly ApplicationDbContext _appDBContext;

        public TicketServices(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        //Get list of all Tickets
        public async Task<List<Tickets>> GetAllTicketAsync()
        {
            return await _appDBContext.Tickets.ToListAsync();
        }

        //Add new ticket
        public async Task<bool> InsertTicketAsync(Tickets ticket)
        {
            await _appDBContext.Tickets.AddAsync(ticket);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public async Task<List<Tickets>> GetTicketByMuserAsync(string user)
        {
            List<Tickets> ticketByUser = new List<Tickets>();
            List<Tickets> tickets = await _appDBContext.Tickets.ToListAsync();
            foreach (var tkt in tickets)
            {

                if (tkt.TicketAssignedUser.UserName == user)
                {

                    ticketByUser.Add(tkt);
                }

            }

            return ticketByUser;

        }

        public async Task<List<Tickets>> GetTicketByMCompanyAsync(string mCompany)
        {
            List<Tickets> ticketByCompany = new List<Tickets>();
            List<Tickets> tickets = await _appDBContext.Tickets.ToListAsync();
            foreach (var tkt in tickets)
            {

                if (tkt.MainCompany == mCompany)
                {
                    ticketByCompany.Add(tkt);
                }

            }

            return ticketByCompany;

        }

        //Get ticket by TicketId
        public async Task<Tickets> GetTicketAsync(int Id)
        {
            Tickets ticket = await _appDBContext.Tickets.FirstOrDefaultAsync(c => c.TicketId.Equals(Id));
            return ticket;
        }

        //Update Ticket
        public async Task<bool> UpdateTicketAsync(Tickets ticket)
        {
            _appDBContext.Tickets.Update(ticket);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        //Delete Ticket
        public async Task<bool> DeleteTicketAsync(Tickets ticket)
        {
            _appDBContext.Tickets.Remove(ticket);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
    }
}
