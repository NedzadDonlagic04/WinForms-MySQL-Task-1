using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Zadatak3 {
    public partial class MySQLProba : Form {
        private MySqlConnection connection;

        private Color connectionStateColor, successStateColor, errorStateColor;
        public MySQLProba() {
            InitializeComponent();

            customComponentInit();
        }
        
        // Method used to do some custom component initialization I didn't
        // want to do in the designer or couldn't do in the designer
        private void customComponentInit() {
            // Settings the colors related to the color circle
            // The successStateColor is the one given to the circle upon connecting to the database
            // The errorStateColor is the one given to the circle upon an error happening or not being connected to the db (initial state)
            // The connectionStateColor is going to take the value of errorStateColor initially

            successStateColor = Color.Green;
            errorStateColor = Color.Red;
            connectionStateColor = errorStateColor;

            // Makes the password text box input look like a single character
            pwdTextBox.PasswordChar = '*';

            // Centers form on the user's screen
            CenterToScreen();

            // Adding a new paint event to the paint event handler to start the painting process
            Paint += new PaintEventHandler(connectionStringInputGroupBox_Paint);
        }

        private void connectionStringInputGroupBox_Paint(object sender, PaintEventArgs e) {
            SolidBrush brush = new SolidBrush(connectionStateColor);

            e.Graphics.FillEllipse(brush, connectionStatusLabel.Location.X + connectionStatusLabel.Width, connectionStatusLabel.Location.Y - 3, 20, 20);
            // The position for the y value is magic numbered so it looks like it's centered, change at risk of mental health loss
        }

        // Method used to connect to the database, it collects values from the needed text boxes and formats them into
        // the connections string
        private void connectToDbBtn_Click(object sender, EventArgs e) {
            var server = serverTextBox.Text.Trim();
            var uid = uidTextBox.Text.Trim();
            var pwd = pwdTextBox.Text.Trim();
            var database = databaseTextBox.Text.Trim();

            var connectionString = string.Format("server={0};uid={1};pwd={2};database={3}", server, uid, pwd, database);

            try {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                connectionStateColor = successStateColor;
            } catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
                connectionStateColor = errorStateColor;
            }
            Refresh();
        }

        // Method used to apply the entered query onto the previously connected database
        private void queryBtn_Click(object sender, EventArgs e) {
            var query = queryRichTextBox.Text.Trim();

            try {
                var command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
            } catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}