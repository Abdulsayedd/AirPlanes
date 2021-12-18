namespace AirPlanes
{
    partial class GetStarted
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetStarted));
            this.Oneway = new System.Windows.Forms.RadioButton();
            this.RoundTrip = new System.Windows.Forms.RadioButton();
            this.From = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.Label();
            this.Exchange = new System.Windows.Forms.Button();
            this.Directflights = new System.Windows.Forms.CheckBox();
            this.Adults = new System.Windows.Forms.Label();
            this.Adultsplus = new System.Windows.Forms.Button();
            this.Adultsminus = new System.Windows.Forms.Button();
            this.Adultstxtbox = new System.Windows.Forms.TextBox();
            this.Childs = new System.Windows.Forms.Label();
            this.Childsplus = new System.Windows.Forms.Button();
            this.Childsminus = new System.Windows.Forms.Button();
            this.Childstxtbox = new System.Windows.Forms.TextBox();
            this.Departxtbox = new System.Windows.Forms.TextBox();
            this.Returntxtbox = new System.Windows.Forms.TextBox();
            this.Depart = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.HomePage = new System.Windows.Forms.Button();
            this.Fromtxtbox = new System.Windows.Forms.TextBox();
            this.Totxtbox = new System.Windows.Forms.TextBox();
            this.CalendarDepartbtn = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.ReturnCalendarbtn = new System.Windows.Forms.Button();
            this.hidedepart = new System.Windows.Forms.Button();
            this.hidereturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Oneway
            // 
            this.Oneway.AutoSize = true;
            this.Oneway.BackColor = System.Drawing.Color.Transparent;
            this.Oneway.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Oneway.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.Oneway.Location = new System.Drawing.Point(275, 85);
            this.Oneway.Name = "Oneway";
            this.Oneway.Size = new System.Drawing.Size(112, 29);
            this.Oneway.TabIndex = 0;
            this.Oneway.TabStop = true;
            this.Oneway.Text = "One-Way";
            this.Oneway.UseVisualStyleBackColor = false;
            this.Oneway.CheckedChanged += new System.EventHandler(this.Oneway_CheckedChanged);
            // 
            // RoundTrip
            // 
            this.RoundTrip.AutoSize = true;
            this.RoundTrip.BackColor = System.Drawing.Color.Transparent;
            this.RoundTrip.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RoundTrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.RoundTrip.Location = new System.Drawing.Point(526, 85);
            this.RoundTrip.Name = "RoundTrip";
            this.RoundTrip.Size = new System.Drawing.Size(133, 29);
            this.RoundTrip.TabIndex = 1;
            this.RoundTrip.TabStop = true;
            this.RoundTrip.Text = "Round-Trip";
            this.RoundTrip.UseVisualStyleBackColor = false;
            this.RoundTrip.CheckedChanged += new System.EventHandler(this.RoundTrip_CheckedChanged);
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.BackColor = System.Drawing.Color.Transparent;
            this.From.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.From.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.From.Location = new System.Drawing.Point(269, 181);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(45, 20);
            this.From.TabIndex = 2;
            this.From.Text = "From";
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.BackColor = System.Drawing.Color.Transparent;
            this.To.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.To.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.To.Location = new System.Drawing.Point(521, 181);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(25, 20);
            this.To.TabIndex = 2;
            this.To.Text = "To";
            // 
            // Exchange
            // 
            this.Exchange.BackColor = System.Drawing.Color.Transparent;
            this.Exchange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exchange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exchange.FlatAppearance.BorderSize = 0;
            this.Exchange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Exchange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exchange.Image = global::AirPlanes.Properties.Resources.exchange12;
            this.Exchange.Location = new System.Drawing.Point(458, 202);
            this.Exchange.Name = "Exchange";
            this.Exchange.Size = new System.Drawing.Size(45, 35);
            this.Exchange.TabIndex = 4;
            this.Exchange.UseVisualStyleBackColor = false;
            this.Exchange.Click += new System.EventHandler(this.Exchange_Click);
            // 
            // Directflights
            // 
            this.Directflights.AutoSize = true;
            this.Directflights.BackColor = System.Drawing.Color.Transparent;
            this.Directflights.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Directflights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.Directflights.Location = new System.Drawing.Point(275, 384);
            this.Directflights.Name = "Directflights";
            this.Directflights.Size = new System.Drawing.Size(157, 24);
            this.Directflights.TabIndex = 5;
            this.Directflights.Text = "Direct Flights Only";
            this.Directflights.UseVisualStyleBackColor = false;
            this.Directflights.CheckedChanged += new System.EventHandler(this.Directflights_CheckedChanged);
            // 
            // Adults
            // 
            this.Adults.AutoSize = true;
            this.Adults.BackColor = System.Drawing.Color.Transparent;
            this.Adults.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Adults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.Adults.Location = new System.Drawing.Point(526, 366);
            this.Adults.Name = "Adults";
            this.Adults.Size = new System.Drawing.Size(79, 27);
            this.Adults.TabIndex = 2;
            this.Adults.Text = "Adults";
            // 
            // Adultsplus
            // 
            this.Adultsplus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Adultsplus.Location = new System.Drawing.Point(584, 400);
            this.Adultsplus.Name = "Adultsplus";
            this.Adultsplus.Size = new System.Drawing.Size(21, 23);
            this.Adultsplus.TabIndex = 6;
            this.Adultsplus.Text = "+";
            this.Adultsplus.UseVisualStyleBackColor = true;
            this.Adultsplus.Click += new System.EventHandler(this.Adultsplus_Click);
            // 
            // Adultsminus
            // 
            this.Adultsminus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Adultsminus.Location = new System.Drawing.Point(527, 400);
            this.Adultsminus.Name = "Adultsminus";
            this.Adultsminus.Size = new System.Drawing.Size(21, 23);
            this.Adultsminus.TabIndex = 6;
            this.Adultsminus.Text = "-";
            this.Adultsminus.UseVisualStyleBackColor = true;
            this.Adultsminus.Click += new System.EventHandler(this.Adultsminus_Click);
            // 
            // Adultstxtbox
            // 
            this.Adultstxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.Adultstxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Adultstxtbox.Location = new System.Drawing.Point(551, 403);
            this.Adultstxtbox.Name = "Adultstxtbox";
            this.Adultstxtbox.Size = new System.Drawing.Size(31, 16);
            this.Adultstxtbox.TabIndex = 7;
            this.Adultstxtbox.Text = "0";
            this.Adultstxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Childs
            // 
            this.Childs.AutoSize = true;
            this.Childs.BackColor = System.Drawing.Color.Transparent;
            this.Childs.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Childs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.Childs.Location = new System.Drawing.Point(623, 366);
            this.Childs.Name = "Childs";
            this.Childs.Size = new System.Drawing.Size(77, 27);
            this.Childs.TabIndex = 2;
            this.Childs.Text = "Childs";
            // 
            // Childsplus
            // 
            this.Childsplus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Childsplus.Location = new System.Drawing.Point(681, 400);
            this.Childsplus.Name = "Childsplus";
            this.Childsplus.Size = new System.Drawing.Size(21, 23);
            this.Childsplus.TabIndex = 6;
            this.Childsplus.Text = "+";
            this.Childsplus.UseVisualStyleBackColor = true;
            this.Childsplus.Click += new System.EventHandler(this.Childsplus_Click);
            // 
            // Childsminus
            // 
            this.Childsminus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Childsminus.Location = new System.Drawing.Point(624, 400);
            this.Childsminus.Name = "Childsminus";
            this.Childsminus.Size = new System.Drawing.Size(21, 23);
            this.Childsminus.TabIndex = 6;
            this.Childsminus.Text = "-";
            this.Childsminus.UseVisualStyleBackColor = true;
            this.Childsminus.Click += new System.EventHandler(this.Childsminus_Click);
            // 
            // Childstxtbox
            // 
            this.Childstxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.Childstxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Childstxtbox.Location = new System.Drawing.Point(648, 403);
            this.Childstxtbox.Name = "Childstxtbox";
            this.Childstxtbox.Size = new System.Drawing.Size(31, 16);
            this.Childstxtbox.TabIndex = 7;
            this.Childstxtbox.Text = "0";
            this.Childstxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Departxtbox
            // 
            this.Departxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.Departxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Departxtbox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Departxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Departxtbox.Location = new System.Drawing.Point(275, 262);
            this.Departxtbox.MinimumSize = new System.Drawing.Size(0, 32);
            this.Departxtbox.Name = "Departxtbox";
            this.Departxtbox.Size = new System.Drawing.Size(166, 32);
            this.Departxtbox.TabIndex = 2;
            this.Departxtbox.Text = " 1/1/2021";
            // 
            // Returntxtbox
            // 
            this.Returntxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.Returntxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Returntxtbox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Returntxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Returntxtbox.Location = new System.Drawing.Point(527, 261);
            this.Returntxtbox.MinimumSize = new System.Drawing.Size(0, 32);
            this.Returntxtbox.Name = "Returntxtbox";
            this.Returntxtbox.Size = new System.Drawing.Size(166, 32);
            this.Returntxtbox.TabIndex = 3;
            this.Returntxtbox.Text = " 1/1/2021";
            // 
            // Depart
            // 
            this.Depart.AutoSize = true;
            this.Depart.BackColor = System.Drawing.Color.Transparent;
            this.Depart.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Depart.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Depart.Location = new System.Drawing.Point(270, 241);
            this.Depart.Name = "Depart";
            this.Depart.Size = new System.Drawing.Size(56, 20);
            this.Depart.TabIndex = 2;
            this.Depart.Text = "Depart";
            // 
            // Return
            // 
            this.Return.AutoSize = true;
            this.Return.BackColor = System.Drawing.Color.Transparent;
            this.Return.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Return.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Return.Location = new System.Drawing.Point(526, 239);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(55, 20);
            this.Return.TabIndex = 2;
            this.Return.Text = "Return";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Transparent;
            this.Search.BackgroundImage = global::AirPlanes.Properties.Resources.Button11;
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Search.Location = new System.Drawing.Point(526, 480);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(186, 60);
            this.Search.TabIndex = 8;
            this.Search.Text = "Search";
            this.Search.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::AirPlanes.Properties.Resources.Button11;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(269, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 60);
            this.button1.TabIndex = 8;
            this.button1.Text = "View";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomePage
            // 
            this.HomePage.BackColor = System.Drawing.Color.Transparent;
            this.HomePage.BackgroundImage = global::AirPlanes.Properties.Resources.Home11;
            this.HomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomePage.FlatAppearance.BorderSize = 0;
            this.HomePage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HomePage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomePage.Location = new System.Drawing.Point(12, 12);
            this.HomePage.Name = "HomePage";
            this.HomePage.Size = new System.Drawing.Size(53, 50);
            this.HomePage.TabIndex = 9;
            this.HomePage.UseVisualStyleBackColor = false;
            this.HomePage.Click += new System.EventHandler(this.HomePage_Click);
            // 
            // Fromtxtbox
            // 
            this.Fromtxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.Fromtxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Fromtxtbox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Fromtxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Fromtxtbox.Location = new System.Drawing.Point(273, 202);
            this.Fromtxtbox.MinimumSize = new System.Drawing.Size(0, 32);
            this.Fromtxtbox.Name = "Fromtxtbox";
            this.Fromtxtbox.Size = new System.Drawing.Size(166, 32);
            this.Fromtxtbox.TabIndex = 2;
            // 
            // Totxtbox
            // 
            this.Totxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.Totxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Totxtbox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Totxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Totxtbox.Location = new System.Drawing.Point(526, 202);
            this.Totxtbox.MinimumSize = new System.Drawing.Size(0, 32);
            this.Totxtbox.Name = "Totxtbox";
            this.Totxtbox.Size = new System.Drawing.Size(166, 32);
            this.Totxtbox.TabIndex = 3;
            // 
            // CalendarDepartbtn
            // 
            this.CalendarDepartbtn.BackColor = System.Drawing.Color.Transparent;
            this.CalendarDepartbtn.BackgroundImage = global::AirPlanes.Properties.Resources.Calendar4;
            this.CalendarDepartbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CalendarDepartbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalendarDepartbtn.FlatAppearance.BorderSize = 0;
            this.CalendarDepartbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CalendarDepartbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CalendarDepartbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalendarDepartbtn.Location = new System.Drawing.Point(412, 264);
            this.CalendarDepartbtn.Name = "CalendarDepartbtn";
            this.CalendarDepartbtn.Size = new System.Drawing.Size(27, 29);
            this.CalendarDepartbtn.TabIndex = 10;
            this.CalendarDepartbtn.UseVisualStyleBackColor = false;
            this.CalendarDepartbtn.Click += new System.EventHandler(this.CalendarDepart_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthCalendar1.Location = new System.Drawing.Point(245, 293);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.MouseLeave += new System.EventHandler(this.hide_Click);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthCalendar2.Location = new System.Drawing.Point(502, 293);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 11;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            this.monthCalendar2.MouseLeave += new System.EventHandler(this.hidereturn_Click);
            // 
            // ReturnCalendarbtn
            // 
            this.ReturnCalendarbtn.BackColor = System.Drawing.Color.Transparent;
            this.ReturnCalendarbtn.BackgroundImage = global::AirPlanes.Properties.Resources.Calendar;
            this.ReturnCalendarbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReturnCalendarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnCalendarbtn.FlatAppearance.BorderSize = 0;
            this.ReturnCalendarbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ReturnCalendarbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ReturnCalendarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnCalendarbtn.Location = new System.Drawing.Point(663, 263);
            this.ReturnCalendarbtn.Name = "ReturnCalendarbtn";
            this.ReturnCalendarbtn.Size = new System.Drawing.Size(29, 30);
            this.ReturnCalendarbtn.TabIndex = 12;
            this.ReturnCalendarbtn.UseVisualStyleBackColor = false;
            this.ReturnCalendarbtn.Click += new System.EventHandler(this.ReturnCalendarbtn_Click);
            // 
            // hidedepart
            // 
            this.hidedepart.BackColor = System.Drawing.Color.Transparent;
            this.hidedepart.FlatAppearance.BorderSize = 0;
            this.hidedepart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hidedepart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hidedepart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hidedepart.Location = new System.Drawing.Point(2, 565);
            this.hidedepart.Name = "hidedepart";
            this.hidedepart.Size = new System.Drawing.Size(25, 23);
            this.hidedepart.TabIndex = 13;
            this.hidedepart.TabStop = false;
            this.hidedepart.UseVisualStyleBackColor = false;
            this.hidedepart.Click += new System.EventHandler(this.hide_Click);
            // 
            // hidereturn
            // 
            this.hidereturn.BackColor = System.Drawing.Color.Transparent;
            this.hidereturn.FlatAppearance.BorderSize = 0;
            this.hidereturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hidereturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hidereturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hidereturn.Location = new System.Drawing.Point(5, 540);
            this.hidereturn.Name = "hidereturn";
            this.hidereturn.Size = new System.Drawing.Size(22, 23);
            this.hidereturn.TabIndex = 14;
            this.hidereturn.UseVisualStyleBackColor = false;
            this.hidereturn.Click += new System.EventHandler(this.hidereturn_Click);
            // 
            // GetStarted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AirPlanes.Properties.Resources.GetStartedWallpaper11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 600);
            this.Controls.Add(this.hidereturn);
            this.Controls.Add(this.hidedepart);
            this.Controls.Add(this.ReturnCalendarbtn);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.CalendarDepartbtn);
            this.Controls.Add(this.HomePage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Childstxtbox);
            this.Controls.Add(this.Adultstxtbox);
            this.Controls.Add(this.Childsminus);
            this.Controls.Add(this.Adultsminus);
            this.Controls.Add(this.Childsplus);
            this.Controls.Add(this.Adultsplus);
            this.Controls.Add(this.Directflights);
            this.Controls.Add(this.Exchange);
            this.Controls.Add(this.Totxtbox);
            this.Controls.Add(this.Returntxtbox);
            this.Controls.Add(this.To);
            this.Controls.Add(this.Fromtxtbox);
            this.Controls.Add(this.Departxtbox);
            this.Controls.Add(this.Childs);
            this.Controls.Add(this.Adults);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Depart);
            this.Controls.Add(this.From);
            this.Controls.Add(this.RoundTrip);
            this.Controls.Add(this.Oneway);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GetStarted";
            this.Text = "GetStarted";
            this.Load += new System.EventHandler(this.GetStarted_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton Oneway;
        private RadioButton RoundTrip;
        private Label From;
        private Label To;
        private Button Exchange;
        private CheckBox Directflights;
        private Label Adults;
        private Button Adultsplus;
        private Button Adultsminus;
        private TextBox Adultstxtbox;
        private Label Childs;
        private Button Childsplus;
        private Button Childsminus;
        private TextBox Childstxtbox;
        private TextBox Departxtbox;
        private TextBox Returntxtbox;
        private Label Depart;
        private Label Return;
        private Button Search;
        private Button button1;
        private Button HomePage;
        private TextBox Fromtxtbox;
        private TextBox Totxtbox;
        private Button CalendarDepartbtn;
        private MonthCalendar monthCalendar1;
        private MonthCalendar monthCalendar2;
        private Button ReturnCalendarbtn;
        private Button hidedepart;
        private Button hidereturn;
    }
}