using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text.Json;
using System.IO;
using BussinessObject.Models;

namespace DataAccess
{
    public class Login
    {
        public string CheckLogin(string Email, string Password)
        {
            string fileName = "Appsetting.json";
            string json = File.ReadAllText(fileName);

            var account = JsonSerializer.Deserialize<Account>(json);

            string role = "";

            if (account != null)
            {
                try
                {
                    if (Email == account.Email && Password == account.Password)
                    {
                        role = account.Role;
                    }
                    else
                    {
                        Member member = new Member();
                        member = MemberDAO.Instance.CheckLogin(Email, Password);
                        if (member != null)
                        {
                            role = "User";
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Wrong email or password" + ex.Message);
                }
            }
            else
            {
                throw new Exception("Login failed....");
            }
            return role;
        }

    }

    public class Account
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}