using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomRservation
{
    class ContactClass
    {
        public int ContactID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String ContactNo { get; set; }
        public String Address { get; set; }
        public String Gender { get; set; }
        public String  DateOfBirth { get; set; }
        public String RoomType { get; set; }
        public String Room { get; set; }




        public void InsertCustomer()
        {
            //int ContactId = txtUn;
            //String FirstName = txtFn;
            //String LastName = txtLn;
            //String ContactNo = txtCn;
            //String Address = txtAd;
            //String Gender = txtGn;
            //String DateOfBirth = txtDob;
            //String RoomType = txtRt;
            //String Room = txtRo;


            String q = "insert into Customers(FirstName,LastName,ContactNumber,Address,Gender,DateOfBirth,RoomType,Rooms) values ('" + FirstName + "','" + LastName + "','" + ContactNo + "','" + Address + "','" + Gender + "','" + this.DateOfBirth + "','" + RoomType + "','" + Room + "')";

            try
            {
                using (DBConect db = new DBConect())
                {

                   bool ok = db.insert(q);

                    if (ok)
                    {
                        MessageBox.Show("User inserted successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else
                    {
                        MessageBox.Show("User insertion failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //SqlCommand cmd = new SqlCommand(q, db.con);
                    //cmd.ExecuteNonQuery();
                    //MessageBox.Show("User inserted successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //clearTexts();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }


        }
       



    }
}
