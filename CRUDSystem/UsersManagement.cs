using CRUDSystem.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDSystem
{
    public partial class UsersManagement : Form
    {
        private const string EDIT_BUTTON_COLUMN_NAME = "Editar";
        private const string DELETE_BUTTON_COLUMN_NAME = "Excluir";
            
        private BindingList<User> userList;
        private BindingList<User> filteredList;

        public UsersManagement()
        {
            InitializeComponent();

            userList = new BindingList<User>();
            filteredList = new BindingList<User>();

            dataGridViewUsers.DataSource = filteredList;
        }

        private void CreateActionButtonsColumns()
        {
            if (!dataGridViewUsers.Columns.Contains(EDIT_BUTTON_COLUMN_NAME))
            {
                DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
                btnUpdate.Name = EDIT_BUTTON_COLUMN_NAME;
                btnUpdate.Text = EDIT_BUTTON_COLUMN_NAME;
                btnUpdate.UseColumnTextForButtonValue = true;
                btnUpdate.FlatStyle = FlatStyle.Flat;
                // blue color for edit button
                btnUpdate.DefaultCellStyle.BackColor = Color.FromArgb(0, 191, 255);
                btnUpdate.DefaultCellStyle.ForeColor = Color.White;
                btnUpdate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 191, 255);
                btnUpdate.DefaultCellStyle.SelectionForeColor = Color.White;
                btnUpdate.DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Regular);
                // remove border from edit button
                btnUpdate.CellTemplate.Style.SelectionBackColor = Color.FromArgb(0, 191, 255);
                // button padding
                btnUpdate.DefaultCellStyle.Padding = new Padding(5);

                dataGridViewUsers.Columns.Add(btnUpdate);
            }

            if (!dataGridViewUsers.Columns.Contains(DELETE_BUTTON_COLUMN_NAME))
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = DELETE_BUTTON_COLUMN_NAME;
                btnDelete.Text = DELETE_BUTTON_COLUMN_NAME;
                btnDelete.UseColumnTextForButtonValue = true;
                btnDelete.FlatStyle = FlatStyle.Flat;
                // red color for delete button
                btnDelete.DefaultCellStyle.BackColor = Color.FromArgb(220, 53, 69);
                btnDelete.DefaultCellStyle.ForeColor = Color.White;
                btnDelete.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 53, 69);
                btnDelete.DefaultCellStyle.SelectionForeColor = Color.White;
                btnDelete.DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Regular);
                // remove border from delete button
                btnDelete.CellTemplate.Style.SelectionBackColor = Color.FromArgb(220, 53, 69);
                // button padding
                btnDelete.DefaultCellStyle.Padding = new Padding(5);

                dataGridViewUsers.Columns.Add(btnDelete);
            }

            dataGridViewUsers.Columns[EDIT_BUTTON_COLUMN_NAME].DisplayIndex = dataGridViewUsers.Columns.Count - 1;
            dataGridViewUsers.Columns[DELETE_BUTTON_COLUMN_NAME].DisplayIndex = dataGridViewUsers.Columns.Count - 1;          
        }

        private void OpenRegisterForm()
        {
            RegisterForm registerForm = new RegisterForm();

            if(registerForm.ShowDialog() == DialogResult.OK)
            {
                User newUser = registerForm.NewUser;

                AddUserToList(newUser);
                CreateActionButtonsColumns();
            }
        }
        private void OpenRegisterForm(User user)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.NewUser = user;
            registerForm.Text = "Editar Usuário";

            if (registerForm.ShowDialog() == DialogResult.OK)
            {
                User newUser = registerForm.NewUser;

                userList[userList.IndexOf(user)] = newUser;
                ApplySearchFilter();
                CreateActionButtonsColumns();
            }
        }

        private void AddUserToList(User user)
        {
            userList.Add(user);
            ApplySearchFilter();
        }

        private void ApplySearchFilter()
        {
            string searchText = txtBoxSearchUser.Text.ToLower().Trim();

            filteredList.Clear();

            foreach(User user in userList)
            {
                if(user.Name.ToLower().Contains(searchText))
                {
                    filteredList.Add(user);
                }
            }
        }

        private void UsersManagement_Load(object sender, EventArgs e)
        {
            CreateActionButtonsColumns();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            OpenRegisterForm();
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dataGridViewUsers.Columns[e.ColumnIndex].Name == EDIT_BUTTON_COLUMN_NAME)
            {
                User selectedUser = userList[e.RowIndex];
                OpenRegisterForm(selectedUser);
            }
            else if (dataGridViewUsers.Columns[e.ColumnIndex].Name == DELETE_BUTTON_COLUMN_NAME)
            {
                if (MessageBox.Show("Tem certeza que deseja excluir este usuário?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    userList.RemoveAt(e.RowIndex);
                    CreateActionButtonsColumns();
                }
            }
        }

        private void txtBoxSearchUser_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }
    }
}
