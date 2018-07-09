using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perputakaan
{
    public partial class LoginPage : Form
    {
        
        public string hashPass(string pass)
        {
            SHA256 sha = new SHA256Managed();
            var def_hash = Convert.ToBase64String(sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(pass + "qwertyuio@#$&^&%&pQWERTYUIOP")));
            return def_hash;
        }

        public void cekPass()
        {
            using (perpustakaanEntities db = new perpustakaanEntities())
            {
                var result = db.logins.FirstOrDefault(i => i.username == "admin");
                if (result.password == "")
                {
                    SHA256 sha = new SHA256Managed();
                    var def_hash = Convert.ToBase64String(sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes("admin" + "qwertyuio@#$&^&%&pQWERTYUIOP")));

                    result.password = def_hash;
                    db.SaveChanges();
                }
                
            }
        }

        public LoginPage()
        {
            InitializeComponent();
            cekPass();
        }

        private void login_Click(object sender, EventArgs e)
        {
            using(perpustakaanEntities db = new perpustakaanEntities())
            {
                var passx = hashPass(pass.Text);
                var result = db.logins.Where(i => i.username == "admin" & i.password ==passx ).ToList();
                if (result.Count > 0)
                {
                    home _home = new home();
                    _home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password Salah!");
                }

            }
        }
    }
}
