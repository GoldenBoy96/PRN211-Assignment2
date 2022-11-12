using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {

        private AssSalesContext _db;

        public MemberRepository()
        {
            _db = new();
        }

        public void Create(Member member)
        {
            _db.Add(member);
            _db.SaveChanges();
        }

        public void Delete(string email)
        {
            Member member = GetMember(email);
            _db.Remove(member);
            _db.SaveChanges();
        }

        public Member GetMember(string email)
        {
            return _db.Members.ToList().FirstOrDefault(c => c.Email.Equals(email));
        }

        public List<Member> GetMembers() => this._db.Members.ToList();

        public void Update(string email)
        {
            _db.SaveChanges();
        }
    }
}
