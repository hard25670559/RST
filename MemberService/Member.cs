using System;
namespace MemberService
{
    public class Member
    {
        public int Id { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public bool Delete { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
