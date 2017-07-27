using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ListView_Access
{
    public partial class Form1 : MetroForm
    {
        private const string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/Hp/Documents/DataBases/spacecraftsDB.mdb;";
        readonly OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();

        /*
       * CONSTRUCTOR
       */
        public Form1()
        {
            InitializeComponent();
            this.setupListView();
           
        }
        /*
         * SETUP LISTVIEW COLUMNS AND PRPERTIES
         */
        private void setupListView()
        {
            mListView.View = View.Details;
            mListView.FullRowSelect = true;
            mListView.MultiSelect = false;
            mListView.Columns.Add("ID", 30);
            mListView.Columns.Add("Name", 150);
            mListView.Columns.Add("Propellant", 150);
            mListView.Columns.Add("Destination", 150);


        }

        /*
         * INSERT INTO DB
         */
        private void add(string name, string propellant, string destination)
        {
            //SQL STMT
            const string sql = "INSERT INTO spacecraftsTB(S_Name,S_Propellant,S_Destination) VALUES(@NAME,@PROPELLANT,@DESTINATION)";
            cmd = new OleDbCommand(sql, con);

            //ADD PARAMS
            cmd.Parameters.AddWithValue("@NAME", name);
            cmd.Parameters.AddWithValue("@PROPELLANT", propellant);
            cmd.Parameters.AddWithValue("@DESTINATION", destination);

            //OPEN CON AND EXEC INSERT
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    clearTxts();
                    MessageBox.Show(@"Successfully Inserted");
                }
                con.Close();
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        /*
         * FILL LISTVIEW
         */
        private void populate(string id, string name, string propellant, string destination)
        {
           //POPULATE SPACECRAFTS
             mListView.Items.Add(new ListViewItem(new[] { id,name,propellant,destination }));
        }

        /*
         * RETRIEVAL OF DATA
         */
        private void retrieve()
        {
            mListView.Items.Clear();
            //SQL STATEMENT
            String sql = "SELECT * FROM spacecraftsTB ";
            cmd = new OleDbCommand(sql, con);
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                //LOOP THROUGH DATATABLE
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
                }

                con.Close();
                //CLEAR DATATABLE 
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        /*
          *  UPDATE DATABASE
         */
        private void update(int id, string name, string propellant, string destination)
        {
            //SQL STATEMENT
            string sql = "UPDATE spacecraftsTB SET S_Name='" + name + "',S_Propellant='" + propellant + "',S_Destination='" + destination + "' WHERE ID=" + id + "";
            cmd = new OleDbCommand(sql, con);

            //OPEN CONNECTION,UPDATE,RETRIEVE DATAGRIDVIEW
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd)
                {
                    UpdateCommand = con.CreateCommand()
                };
                adapter.UpdateCommand.CommandText = sql;
                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    clearTxts();
                    MessageBox.Show(@"Successfully Updated");
                }
                con.Close();

                //REFRESH DATA
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        /*
         * DELETE FROM DATABASE
         */
        private void delete(int id)
        {
            //SQL STATEMENTT
            String sql = "DELETE FROM spacecraftsTB WHERE ID=" + id + "";
            cmd = new OleDbCommand(sql, con);

            //'OPEN CONNECTION,EXECUTE DELETE,CLOSE CONNECTION
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.DeleteCommand = con.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;

                //PROMPT FOR CONFIRMATION BEFORE DELETING
                if (MessageBox.Show(@"Are you sure to permanently delete this?", @"DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        clearTxts();
                        MessageBox.Show(@"Successfully deleted");
                    }
                }
                con.Close();
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        /*
         * CLEAR TEXTBOXES
         */
        private void clearTxts()
        {
            nameTxt.Text = "";
            propellantTxt.Text = "";
            destinationTxt.Text = "";
        }



        /*
         * ADD BUTTON CLICKED
         */
        private void addBtn_Click(object sender, EventArgs e)
        {
            add(nameTxt.Text, propellantTxt.Text, destinationTxt.Text);

        }
        /*
       * RETRIEVE BUTTON CLICKED
       */
        private void retrieveBtn_Click(object sender, EventArgs e)
        {
            retrieve();
        }
        /*
         * UPDATE BUTTON CLICKED
         */
        private void updateBtn_Click(object sender, EventArgs e)
        {

            int selectedIndex = mListView.SelectedIndices[0];
            if (selectedIndex != -1)
            {

                String selected = mListView.SelectedItems[0].SubItems[0].Text;
                int id = Convert.ToInt32(selected);
                update(id, nameTxt.Text, propellantTxt.Text, destinationTxt.Text);
            }

        }
        /*
        * DELETE BUTTON CLICKED
        */
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = mListView.SelectedIndices[0];
            if (selectedIndex != -1)
            {
                String selected = mListView.SelectedItems[0].SubItems[0].Text;
                int id = Convert.ToInt32(selected);
                delete(id);
            }
        }

        /*
         * CLEAR BUTTON CLICKED
         */
        private void clearBtn_Click(object sender, EventArgs e)
        {
            mListView.Items.Clear();
            clearTxts();
        }

        /*
         * LISTVIEW SELECTION CHANGED
         */
        private void mListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                int selectedIndex = mListView.SelectedIndices[0];
                if (selectedIndex != -1)
                {
                    if (mListView.SelectedItems[0].SubItems[0].Text != null)
                    {
                        string name = mListView.SelectedItems[0].SubItems[1].Text;
                        string propellant = mListView.SelectedItems[0].SubItems[2].Text;
                        string destination = mListView.SelectedItems[0].SubItems[3].Text;
                        
                        nameTxt.Text = name;
                        propellantTxt.Text = propellant;
                        destinationTxt.Text = destination;
                    }

                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }


    }
}