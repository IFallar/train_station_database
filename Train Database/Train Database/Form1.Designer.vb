<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.trips = New System.Windows.Forms.TabPage()
        Me.reset = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.add = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.get_trip = New System.Windows.Forms.Button()
        Me.ComboBox12 = New System.Windows.Forms.ComboBox()
        Me.ComboBox11 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.trip_dep = New System.Windows.Forms.ComboBox()
        Me.trip_arr = New System.Windows.Forms.ComboBox()
        Me.trip_selected_hours = New System.Windows.Forms.ComboBox()
        Me.trip_selected_day = New System.Windows.Forms.ComboBox()
        Me.trip_to = New System.Windows.Forms.ComboBox()
        Me.trip_from = New System.Windows.Forms.ComboBox()
        Me.trip_selected_train = New System.Windows.Forms.ComboBox()
        Me.trip_selected_route = New System.Windows.Forms.ComboBox()
        Me.trip_id = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.trip_dep_time = New System.Windows.Forms.Label()
        Me.trip_des = New System.Windows.Forms.Label()
        Me.trip_arr_time = New System.Windows.Forms.Label()
        Me.trip_hours = New System.Windows.Forms.Label()
        Me.trip_day = New System.Windows.Forms.Label()
        Me.trip_source = New System.Windows.Forms.Label()
        Me.trip_train = New System.Windows.Forms.Label()
        Me.trip_route = New System.Windows.Forms.Label()
        Me.routes = New System.Windows.Forms.TabPage()
        Me.route_add = New System.Windows.Forms.Button()
        Me.route_delete = New System.Windows.Forms.Button()
        Me.route_update = New System.Windows.Forms.Button()
        Me.reset_routes = New System.Windows.Forms.Button()
        Me.bounds = New System.Windows.Forms.ListBox()
        Me.boundaries = New System.Windows.Forms.Label()
        Me.active_trains = New System.Windows.Forms.ListBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbx_route_end = New System.Windows.Forms.ComboBox()
        Me.tbx_route_start = New System.Windows.Forms.ComboBox()
        Me.tbx_route_name = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_get_route = New System.Windows.Forms.Button()
        Me.tbx_route_id = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.trains = New System.Windows.Forms.TabPage()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.reset_trains = New System.Windows.Forms.Button()
        Me.tbx_train_name = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.add_train = New System.Windows.Forms.Button()
        Me.delete_train = New System.Windows.Forms.Button()
        Me.update_train = New System.Windows.Forms.Button()
        Me.cbx_train_route = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.get_set_trains = New System.Windows.Forms.Button()
        Me.tbx_train_id = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.stations = New System.Windows.Forms.TabPage()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.part_of_route_list = New System.Windows.Forms.ListBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tbx_station_name = New System.Windows.Forms.TextBox()
        Me.btn_update_station = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.get_station = New System.Windows.Forms.Button()
        Me.tbx_stations_id = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.stop_btn_1 = New System.Windows.Forms.Button()
        Me.stop_btn_2 = New System.Windows.Forms.Button()
        Me.stop_btn_3 = New System.Windows.Forms.Button()
        Me.stop_btn_4 = New System.Windows.Forms.Button()
        Me.stop_btn_5 = New System.Windows.Forms.Button()
        Me.stop_btn_6 = New System.Windows.Forms.Button()
        Me.stop_btn_7 = New System.Windows.Forms.Button()
        Me.stop_btn_8 = New System.Windows.Forms.Button()
        Me.stop_btn_9 = New System.Windows.Forms.Button()
        Me.stop_btn_10 = New System.Windows.Forms.Button()
        Me.stop_btn_11 = New System.Windows.Forms.Button()
        Me.stop_btn_12 = New System.Windows.Forms.Button()
        Me.stop_btn_13 = New System.Windows.Forms.Button()
        Me.stop_btn_14 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_mon = New System.Windows.Forms.Button()
        Me.btn_wed = New System.Windows.Forms.Button()
        Me.btn_tue = New System.Windows.Forms.Button()
        Me.btn_sat = New System.Windows.Forms.Button()
        Me.btn_fri = New System.Windows.Forms.Button()
        Me.btn_thu = New System.Windows.Forms.Button()
        Me.btn_sun = New System.Windows.Forms.Button()
        Me.day_list = New System.Windows.Forms.ListBox()
        Me.Label18 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.trips.SuspendLayout()
        Me.routes.SuspendLayout()
        Me.trains.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.stations.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(744, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(462, 337)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(19, 423)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1187, 226)
        Me.DataGridView1.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.trips)
        Me.TabControl1.Controls.Add(Me.routes)
        Me.TabControl1.Controls.Add(Me.trains)
        Me.TabControl1.Controls.Add(Me.stations)
        Me.TabControl1.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(19, 23)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(10, 3)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(719, 363)
        Me.TabControl1.TabIndex = 3
        '
        'trips
        '
        Me.trips.Controls.Add(Me.reset)
        Me.trips.Controls.Add(Me.Button1)
        Me.trips.Controls.Add(Me.add)
        Me.trips.Controls.Add(Me.delete)
        Me.trips.Controls.Add(Me.edit)
        Me.trips.Controls.Add(Me.get_trip)
        Me.trips.Controls.Add(Me.ComboBox12)
        Me.trips.Controls.Add(Me.ComboBox11)
        Me.trips.Controls.Add(Me.Label5)
        Me.trips.Controls.Add(Me.Label6)
        Me.trips.Controls.Add(Me.Label4)
        Me.trips.Controls.Add(Me.Label1)
        Me.trips.Controls.Add(Me.trip_dep)
        Me.trips.Controls.Add(Me.trip_arr)
        Me.trips.Controls.Add(Me.trip_selected_hours)
        Me.trips.Controls.Add(Me.trip_selected_day)
        Me.trips.Controls.Add(Me.trip_to)
        Me.trips.Controls.Add(Me.trip_from)
        Me.trips.Controls.Add(Me.trip_selected_train)
        Me.trips.Controls.Add(Me.trip_selected_route)
        Me.trips.Controls.Add(Me.trip_id)
        Me.trips.Controls.Add(Me.Label12)
        Me.trips.Controls.Add(Me.trip_dep_time)
        Me.trips.Controls.Add(Me.trip_des)
        Me.trips.Controls.Add(Me.trip_arr_time)
        Me.trips.Controls.Add(Me.trip_hours)
        Me.trips.Controls.Add(Me.trip_day)
        Me.trips.Controls.Add(Me.trip_source)
        Me.trips.Controls.Add(Me.trip_train)
        Me.trips.Controls.Add(Me.trip_route)
        Me.trips.Location = New System.Drawing.Point(4, 26)
        Me.trips.Name = "trips"
        Me.trips.Padding = New System.Windows.Forms.Padding(3)
        Me.trips.Size = New System.Drawing.Size(711, 333)
        Me.trips.TabIndex = 0
        Me.trips.Text = "TRIP INFORMATION"
        Me.trips.UseVisualStyleBackColor = True
        '
        'reset
        '
        Me.reset.BackColor = System.Drawing.Color.White
        Me.reset.ForeColor = System.Drawing.Color.Maroon
        Me.reset.Location = New System.Drawing.Point(673, 6)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(32, 32)
        Me.reset.TabIndex = 48
        Me.reset.Text = "🗑️"
        Me.reset.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(311, 290)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 25)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "GO"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'add
        '
        Me.add.BackColor = System.Drawing.Color.DarkGreen
        Me.add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.add.FlatAppearance.BorderSize = 0
        Me.add.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.add.Location = New System.Drawing.Point(597, 202)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(92, 25)
        Me.add.TabIndex = 46
        Me.add.Text = "ADD"
        Me.add.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.add.UseVisualStyleBackColor = False
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.DarkRed
        Me.delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.delete.FlatAppearance.BorderSize = 0
        Me.delete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.delete.Location = New System.Drawing.Point(500, 202)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(92, 25)
        Me.delete.TabIndex = 45
        Me.delete.Text = "DELETE"
        Me.delete.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.delete.UseVisualStyleBackColor = False
        '
        'edit
        '
        Me.edit.BackColor = System.Drawing.Color.MidnightBlue
        Me.edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.edit.FlatAppearance.BorderSize = 0
        Me.edit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.edit.Location = New System.Drawing.Point(402, 202)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(92, 25)
        Me.edit.TabIndex = 44
        Me.edit.Text = "UPDATE"
        Me.edit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.edit.UseVisualStyleBackColor = False
        '
        'get_trip
        '
        Me.get_trip.BackColor = System.Drawing.Color.DarkBlue
        Me.get_trip.FlatAppearance.BorderSize = 0
        Me.get_trip.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.get_trip.Location = New System.Drawing.Point(113, 54)
        Me.get_trip.Name = "get_trip"
        Me.get_trip.Size = New System.Drawing.Size(79, 25)
        Me.get_trip.TabIndex = 43
        Me.get_trip.Text = "GET"
        Me.get_trip.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.get_trip.UseVisualStyleBackColor = False
        '
        'ComboBox12
        '
        Me.ComboBox12.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox12.FormattingEnabled = True
        Me.ComboBox12.Items.AddRange(New Object() {"ID:", "ROUTE:", "TRAIN:", "DEPARTS FROM:", "ARRIVES IN:", "DAY:", "ARRIVES:", "DEPARTS:"})
        Me.ComboBox12.Location = New System.Drawing.Point(13, 291)
        Me.ComboBox12.Name = "ComboBox12"
        Me.ComboBox12.Size = New System.Drawing.Size(119, 23)
        Me.ComboBox12.TabIndex = 42
        '
        'ComboBox11
        '
        Me.ComboBox11.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox11.FormattingEnabled = True
        Me.ComboBox11.Items.AddRange(New Object() {"Cornelia-Travertino Route", "Quintilianni-Laurentina Route", "Airport Line"})
        Me.ComboBox11.Location = New System.Drawing.Point(138, 291)
        Me.ComboBox11.Name = "ComboBox11"
        Me.ComboBox11.Size = New System.Drawing.Size(168, 23)
        Me.ComboBox11.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "WHERE:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(139, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 17)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "IS:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(9, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "FIND TRIP:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(6, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "SCHEDULE NEW TRIP:"
        '
        'trip_dep
        '
        Me.trip_dep.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trip_dep.FormattingEnabled = True
        Me.trip_dep.Location = New System.Drawing.Point(547, 154)
        Me.trip_dep.Name = "trip_dep"
        Me.trip_dep.Size = New System.Drawing.Size(142, 23)
        Me.trip_dep.TabIndex = 34
        '
        'trip_arr
        '
        Me.trip_arr.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trip_arr.FormattingEnabled = True
        Me.trip_arr.Location = New System.Drawing.Point(402, 154)
        Me.trip_arr.Name = "trip_arr"
        Me.trip_arr.Size = New System.Drawing.Size(139, 23)
        Me.trip_arr.TabIndex = 33
        '
        'trip_selected_hours
        '
        Me.trip_selected_hours.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trip_selected_hours.FormattingEnabled = True
        Me.trip_selected_hours.Items.AddRange(New Object() {"MORNING", "MIDDAY", "AFTERNOON", "EVENING"})
        Me.trip_selected_hours.Location = New System.Drawing.Point(547, 108)
        Me.trip_selected_hours.Name = "trip_selected_hours"
        Me.trip_selected_hours.Size = New System.Drawing.Size(142, 23)
        Me.trip_selected_hours.TabIndex = 32
        '
        'trip_selected_day
        '
        Me.trip_selected_day.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trip_selected_day.FormattingEnabled = True
        Me.trip_selected_day.Location = New System.Drawing.Point(402, 108)
        Me.trip_selected_day.Name = "trip_selected_day"
        Me.trip_selected_day.Size = New System.Drawing.Size(139, 23)
        Me.trip_selected_day.TabIndex = 31
        '
        'trip_to
        '
        Me.trip_to.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trip_to.FormattingEnabled = True
        Me.trip_to.Location = New System.Drawing.Point(199, 154)
        Me.trip_to.Name = "trip_to"
        Me.trip_to.Size = New System.Drawing.Size(176, 23)
        Me.trip_to.TabIndex = 30
        '
        'trip_from
        '
        Me.trip_from.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trip_from.FormattingEnabled = True
        Me.trip_from.Location = New System.Drawing.Point(16, 154)
        Me.trip_from.Name = "trip_from"
        Me.trip_from.Size = New System.Drawing.Size(176, 23)
        Me.trip_from.TabIndex = 29
        '
        'trip_selected_train
        '
        Me.trip_selected_train.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trip_selected_train.FormattingEnabled = True
        Me.trip_selected_train.Location = New System.Drawing.Point(199, 109)
        Me.trip_selected_train.Name = "trip_selected_train"
        Me.trip_selected_train.Size = New System.Drawing.Size(176, 23)
        Me.trip_selected_train.TabIndex = 28
        '
        'trip_selected_route
        '
        Me.trip_selected_route.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trip_selected_route.FormattingEnabled = True
        Me.trip_selected_route.Location = New System.Drawing.Point(17, 108)
        Me.trip_selected_route.Name = "trip_selected_route"
        Me.trip_selected_route.Size = New System.Drawing.Size(176, 23)
        Me.trip_selected_route.TabIndex = 27
        '
        'trip_id
        '
        Me.trip_id.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trip_id.Location = New System.Drawing.Point(16, 56)
        Me.trip_id.Name = "trip_id"
        Me.trip_id.Size = New System.Drawing.Size(92, 22)
        Me.trip_id.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 17)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "ID"
        '
        'trip_dep_time
        '
        Me.trip_dep_time.AutoSize = True
        Me.trip_dep_time.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trip_dep_time.Location = New System.Drawing.Point(544, 134)
        Me.trip_dep_time.Name = "trip_dep_time"
        Me.trip_dep_time.Size = New System.Drawing.Size(113, 17)
        Me.trip_dep_time.TabIndex = 19
        Me.trip_dep_time.Text = "DEPARTURE TIME"
        '
        'trip_des
        '
        Me.trip_des.AutoSize = True
        Me.trip_des.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trip_des.Location = New System.Drawing.Point(196, 134)
        Me.trip_des.Name = "trip_des"
        Me.trip_des.Size = New System.Drawing.Size(96, 17)
        Me.trip_des.TabIndex = 17
        Me.trip_des.Text = "DESTINATION:"
        '
        'trip_arr_time
        '
        Me.trip_arr_time.AutoSize = True
        Me.trip_arr_time.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trip_arr_time.Location = New System.Drawing.Point(401, 134)
        Me.trip_arr_time.Name = "trip_arr_time"
        Me.trip_arr_time.Size = New System.Drawing.Size(93, 17)
        Me.trip_arr_time.TabIndex = 10
        Me.trip_arr_time.Text = "ARRIVAL TIME"
        '
        'trip_hours
        '
        Me.trip_hours.AutoSize = True
        Me.trip_hours.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trip_hours.Location = New System.Drawing.Point(544, 88)
        Me.trip_hours.Name = "trip_hours"
        Me.trip_hours.Size = New System.Drawing.Size(54, 17)
        Me.trip_hours.TabIndex = 8
        Me.trip_hours.Text = "HOURS"
        '
        'trip_day
        '
        Me.trip_day.AutoSize = True
        Me.trip_day.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trip_day.Location = New System.Drawing.Point(401, 88)
        Me.trip_day.Name = "trip_day"
        Me.trip_day.Size = New System.Drawing.Size(34, 17)
        Me.trip_day.TabIndex = 6
        Me.trip_day.Text = "DAY"
        '
        'trip_source
        '
        Me.trip_source.AutoSize = True
        Me.trip_source.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trip_source.Location = New System.Drawing.Point(13, 134)
        Me.trip_source.Name = "trip_source"
        Me.trip_source.Size = New System.Drawing.Size(110, 17)
        Me.trip_source.TabIndex = 4
        Me.trip_source.Text = "DEPARTS FROM:"
        '
        'trip_train
        '
        Me.trip_train.AutoSize = True
        Me.trip_train.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trip_train.Location = New System.Drawing.Point(196, 88)
        Me.trip_train.Name = "trip_train"
        Me.trip_train.Size = New System.Drawing.Size(45, 17)
        Me.trip_train.TabIndex = 2
        Me.trip_train.Text = "TRAIN"
        '
        'trip_route
        '
        Me.trip_route.AutoSize = True
        Me.trip_route.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trip_route.Location = New System.Drawing.Point(14, 88)
        Me.trip_route.Name = "trip_route"
        Me.trip_route.Size = New System.Drawing.Size(51, 17)
        Me.trip_route.TabIndex = 0
        Me.trip_route.Text = "ROUTE"
        '
        'routes
        '
        Me.routes.Controls.Add(Me.route_add)
        Me.routes.Controls.Add(Me.route_delete)
        Me.routes.Controls.Add(Me.route_update)
        Me.routes.Controls.Add(Me.reset_routes)
        Me.routes.Controls.Add(Me.bounds)
        Me.routes.Controls.Add(Me.boundaries)
        Me.routes.Controls.Add(Me.active_trains)
        Me.routes.Controls.Add(Me.Label14)
        Me.routes.Controls.Add(Me.tbx_route_end)
        Me.routes.Controls.Add(Me.tbx_route_start)
        Me.routes.Controls.Add(Me.tbx_route_name)
        Me.routes.Controls.Add(Me.Label9)
        Me.routes.Controls.Add(Me.Label10)
        Me.routes.Controls.Add(Me.Label11)
        Me.routes.Controls.Add(Me.btn_get_route)
        Me.routes.Controls.Add(Me.tbx_route_id)
        Me.routes.Controls.Add(Me.Label8)
        Me.routes.Controls.Add(Me.Label7)
        Me.routes.Location = New System.Drawing.Point(4, 26)
        Me.routes.Name = "routes"
        Me.routes.Padding = New System.Windows.Forms.Padding(3)
        Me.routes.Size = New System.Drawing.Size(711, 333)
        Me.routes.TabIndex = 1
        Me.routes.Text = "ROUTES"
        Me.routes.UseVisualStyleBackColor = True
        '
        'route_add
        '
        Me.route_add.BackColor = System.Drawing.Color.DarkGreen
        Me.route_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.route_add.FlatAppearance.BorderSize = 0
        Me.route_add.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.route_add.Location = New System.Drawing.Point(258, 213)
        Me.route_add.Name = "route_add"
        Me.route_add.Size = New System.Drawing.Size(119, 25)
        Me.route_add.TabIndex = 69
        Me.route_add.Text = "ADD"
        Me.route_add.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.route_add.UseVisualStyleBackColor = False
        '
        'route_delete
        '
        Me.route_delete.BackColor = System.Drawing.Color.DarkRed
        Me.route_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.route_delete.FlatAppearance.BorderSize = 0
        Me.route_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.route_delete.Location = New System.Drawing.Point(140, 213)
        Me.route_delete.Name = "route_delete"
        Me.route_delete.Size = New System.Drawing.Size(109, 25)
        Me.route_delete.TabIndex = 68
        Me.route_delete.Text = "DELETE"
        Me.route_delete.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.route_delete.UseVisualStyleBackColor = False
        '
        'route_update
        '
        Me.route_update.BackColor = System.Drawing.Color.MidnightBlue
        Me.route_update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.route_update.FlatAppearance.BorderSize = 0
        Me.route_update.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.route_update.Location = New System.Drawing.Point(16, 213)
        Me.route_update.Name = "route_update"
        Me.route_update.Size = New System.Drawing.Size(115, 25)
        Me.route_update.TabIndex = 67
        Me.route_update.Text = "UPDATE"
        Me.route_update.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.route_update.UseVisualStyleBackColor = False
        '
        'reset_routes
        '
        Me.reset_routes.BackColor = System.Drawing.Color.White
        Me.reset_routes.ForeColor = System.Drawing.Color.Maroon
        Me.reset_routes.Location = New System.Drawing.Point(673, 6)
        Me.reset_routes.Name = "reset_routes"
        Me.reset_routes.Size = New System.Drawing.Size(32, 32)
        Me.reset_routes.TabIndex = 64
        Me.reset_routes.Text = "🗑️"
        Me.reset_routes.UseVisualStyleBackColor = False
        '
        'bounds
        '
        Me.bounds.FormattingEnabled = True
        Me.bounds.ItemHeight = 17
        Me.bounds.Location = New System.Drawing.Point(417, 59)
        Me.bounds.Name = "bounds"
        Me.bounds.Size = New System.Drawing.Size(270, 55)
        Me.bounds.TabIndex = 63
        '
        'boundaries
        '
        Me.boundaries.AutoSize = True
        Me.boundaries.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boundaries.Location = New System.Drawing.Point(417, 39)
        Me.boundaries.Name = "boundaries"
        Me.boundaries.Size = New System.Drawing.Size(91, 17)
        Me.boundaries.TabIndex = 62
        Me.boundaries.Text = "BOUNDARIES"
        '
        'active_trains
        '
        Me.active_trains.FormattingEnabled = True
        Me.active_trains.ItemHeight = 17
        Me.active_trains.Location = New System.Drawing.Point(417, 166)
        Me.active_trains.Name = "active_trains"
        Me.active_trains.Size = New System.Drawing.Size(273, 72)
        Me.active_trains.TabIndex = 60
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(414, 145)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 17)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "ASSIGNED TRAINS"
        '
        'tbx_route_end
        '
        Me.tbx_route_end.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_route_end.FormattingEnabled = True
        Me.tbx_route_end.Location = New System.Drawing.Point(200, 166)
        Me.tbx_route_end.Name = "tbx_route_end"
        Me.tbx_route_end.Size = New System.Drawing.Size(176, 23)
        Me.tbx_route_end.TabIndex = 52
        '
        'tbx_route_start
        '
        Me.tbx_route_start.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_route_start.FormattingEnabled = True
        Me.tbx_route_start.Location = New System.Drawing.Point(17, 166)
        Me.tbx_route_start.Name = "tbx_route_start"
        Me.tbx_route_start.Size = New System.Drawing.Size(176, 23)
        Me.tbx_route_start.TabIndex = 51
        '
        'tbx_route_name
        '
        Me.tbx_route_name.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_route_name.FormattingEnabled = True
        Me.tbx_route_name.Items.AddRange(New Object() {""})
        Me.tbx_route_name.Location = New System.Drawing.Point(18, 114)
        Me.tbx_route_name.Name = "tbx_route_name"
        Me.tbx_route_name.Size = New System.Drawing.Size(176, 23)
        Me.tbx_route_name.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(197, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 17)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "ENDS IN:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 17)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "STARTS FROM:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 17)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "ROUTE NAME"
        '
        'btn_get_route
        '
        Me.btn_get_route.BackColor = System.Drawing.Color.DarkBlue
        Me.btn_get_route.FlatAppearance.BorderSize = 0
        Me.btn_get_route.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_get_route.Location = New System.Drawing.Point(113, 57)
        Me.btn_get_route.Name = "btn_get_route"
        Me.btn_get_route.Size = New System.Drawing.Size(79, 25)
        Me.btn_get_route.TabIndex = 46
        Me.btn_get_route.Text = "GET"
        Me.btn_get_route.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_get_route.UseVisualStyleBackColor = False
        '
        'tbx_route_id
        '
        Me.tbx_route_id.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_route_id.Location = New System.Drawing.Point(16, 59)
        Me.tbx_route_id.Name = "tbx_route_id"
        Me.tbx_route_id.Size = New System.Drawing.Size(92, 22)
        Me.tbx_route_id.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 17)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "ID"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tw Cen MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(6, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 23)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "MANAGE ROUTES"
        '
        'trains
        '
        Me.trains.Controls.Add(Me.Label18)
        Me.trains.Controls.Add(Me.day_list)
        Me.trains.Controls.Add(Me.Label29)
        Me.trains.Controls.Add(Me.Panel1)
        Me.trains.Controls.Add(Me.reset_trains)
        Me.trains.Controls.Add(Me.tbx_train_name)
        Me.trains.Controls.Add(Me.Label17)
        Me.trains.Controls.Add(Me.add_train)
        Me.trains.Controls.Add(Me.delete_train)
        Me.trains.Controls.Add(Me.update_train)
        Me.trains.Controls.Add(Me.cbx_train_route)
        Me.trains.Controls.Add(Me.Label13)
        Me.trains.Controls.Add(Me.Label15)
        Me.trains.Controls.Add(Me.get_set_trains)
        Me.trains.Controls.Add(Me.tbx_train_id)
        Me.trains.Controls.Add(Me.Label16)
        Me.trains.Location = New System.Drawing.Point(4, 26)
        Me.trains.Name = "trains"
        Me.trains.Padding = New System.Windows.Forms.Padding(3)
        Me.trains.Size = New System.Drawing.Size(711, 333)
        Me.trains.TabIndex = 2
        Me.trains.Text = "TRAINS"
        Me.trains.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(409, 103)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(112, 17)
        Me.Label29.TabIndex = 85
        Me.Label29.Text = "ASSIGNED DAYS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.btn_sun)
        Me.Panel1.Controls.Add(Me.btn_mon)
        Me.Panel1.Controls.Add(Me.btn_sat)
        Me.Panel1.Controls.Add(Me.btn_wed)
        Me.Panel1.Controls.Add(Me.btn_fri)
        Me.Panel1.Controls.Add(Me.btn_tue)
        Me.Panel1.Controls.Add(Me.btn_thu)
        Me.Panel1.Location = New System.Drawing.Point(412, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(293, 121)
        Me.Panel1.TabIndex = 84
        '
        'reset_trains
        '
        Me.reset_trains.BackColor = System.Drawing.Color.White
        Me.reset_trains.ForeColor = System.Drawing.Color.Maroon
        Me.reset_trains.Location = New System.Drawing.Point(673, 6)
        Me.reset_trains.Name = "reset_trains"
        Me.reset_trains.Size = New System.Drawing.Size(32, 32)
        Me.reset_trains.TabIndex = 82
        Me.reset_trains.Text = "🗑️"
        Me.reset_trains.UseVisualStyleBackColor = False
        '
        'tbx_train_name
        '
        Me.tbx_train_name.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_train_name.Location = New System.Drawing.Point(14, 123)
        Me.tbx_train_name.Name = "tbx_train_name"
        Me.tbx_train_name.Size = New System.Drawing.Size(362, 22)
        Me.tbx_train_name.TabIndex = 81
        '
        'Label17
        '
        Me.Label17.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tw Cen MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(7, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(162, 23)
        Me.Label17.TabIndex = 80
        Me.Label17.Text = "MANAGE TRAINS"
        '
        'add_train
        '
        Me.add_train.BackColor = System.Drawing.Color.DarkGreen
        Me.add_train.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.add_train.FlatAppearance.BorderSize = 0
        Me.add_train.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.add_train.Location = New System.Drawing.Point(258, 219)
        Me.add_train.Name = "add_train"
        Me.add_train.Size = New System.Drawing.Size(119, 25)
        Me.add_train.TabIndex = 79
        Me.add_train.Text = "ADD"
        Me.add_train.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.add_train.UseVisualStyleBackColor = False
        '
        'delete_train
        '
        Me.delete_train.BackColor = System.Drawing.Color.DarkRed
        Me.delete_train.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.delete_train.FlatAppearance.BorderSize = 0
        Me.delete_train.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.delete_train.Location = New System.Drawing.Point(140, 219)
        Me.delete_train.Name = "delete_train"
        Me.delete_train.Size = New System.Drawing.Size(109, 25)
        Me.delete_train.TabIndex = 78
        Me.delete_train.Text = "DELETE"
        Me.delete_train.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.delete_train.UseVisualStyleBackColor = False
        '
        'update_train
        '
        Me.update_train.BackColor = System.Drawing.Color.MidnightBlue
        Me.update_train.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.update_train.FlatAppearance.BorderSize = 0
        Me.update_train.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.update_train.Location = New System.Drawing.Point(16, 219)
        Me.update_train.Name = "update_train"
        Me.update_train.Size = New System.Drawing.Size(115, 25)
        Me.update_train.TabIndex = 77
        Me.update_train.Text = "UPDATE"
        Me.update_train.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.update_train.UseVisualStyleBackColor = False
        '
        'cbx_train_route
        '
        Me.cbx_train_route.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_train_route.FormattingEnabled = True
        Me.cbx_train_route.Location = New System.Drawing.Point(14, 176)
        Me.cbx_train_route.Name = "cbx_train_route"
        Me.cbx_train_route.Size = New System.Drawing.Size(362, 23)
        Me.cbx_train_route.TabIndex = 76
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 17)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "ASSIGNED ROUTE"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 103)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 17)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "TRAIN NAME"
        '
        'get_set_trains
        '
        Me.get_set_trains.BackColor = System.Drawing.Color.DarkBlue
        Me.get_set_trains.FlatAppearance.BorderSize = 0
        Me.get_set_trains.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.get_set_trains.Location = New System.Drawing.Point(111, 64)
        Me.get_set_trains.Name = "get_set_trains"
        Me.get_set_trains.Size = New System.Drawing.Size(79, 25)
        Me.get_set_trains.TabIndex = 72
        Me.get_set_trains.Text = "GET"
        Me.get_set_trains.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.get_set_trains.UseVisualStyleBackColor = False
        '
        'tbx_train_id
        '
        Me.tbx_train_id.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_train_id.Location = New System.Drawing.Point(13, 65)
        Me.tbx_train_id.Name = "tbx_train_id"
        Me.tbx_train_id.Size = New System.Drawing.Size(92, 22)
        Me.tbx_train_id.TabIndex = 71
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 45)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(20, 17)
        Me.Label16.TabIndex = 70
        Me.Label16.Text = "ID"
        '
        'stations
        '
        Me.stations.Controls.Add(Me.Label22)
        Me.stations.Controls.Add(Me.part_of_route_list)
        Me.stations.Controls.Add(Me.Label21)
        Me.stations.Controls.Add(Me.Button3)
        Me.stations.Controls.Add(Me.tbx_station_name)
        Me.stations.Controls.Add(Me.btn_update_station)
        Me.stations.Controls.Add(Me.Label19)
        Me.stations.Controls.Add(Me.get_station)
        Me.stations.Controls.Add(Me.tbx_stations_id)
        Me.stations.Controls.Add(Me.Label20)
        Me.stations.Location = New System.Drawing.Point(4, 26)
        Me.stations.Name = "stations"
        Me.stations.Padding = New System.Windows.Forms.Padding(3)
        Me.stations.Size = New System.Drawing.Size(711, 333)
        Me.stations.TabIndex = 3
        Me.stations.Text = "STATIONS"
        Me.stations.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(12, 107)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 17)
        Me.Label22.TabIndex = 96
        Me.Label22.Text = "PART OF:"
        '
        'part_of_route_list
        '
        Me.part_of_route_list.FormattingEnabled = True
        Me.part_of_route_list.ItemHeight = 17
        Me.part_of_route_list.Location = New System.Drawing.Point(13, 127)
        Me.part_of_route_list.Name = "part_of_route_list"
        Me.part_of_route_list.Size = New System.Drawing.Size(623, 72)
        Me.part_of_route_list.TabIndex = 95
        '
        'Label21
        '
        Me.Label21.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tw Cen MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label21.Location = New System.Drawing.Point(11, 8)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(190, 23)
        Me.Label21.TabIndex = 94
        Me.Label21.Text = "MANAGE STATIONS "
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.ForeColor = System.Drawing.Color.Maroon
        Me.Button3.Location = New System.Drawing.Point(672, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 32)
        Me.Button3.TabIndex = 93
        Me.Button3.Text = "🗑️"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'tbx_station_name
        '
        Me.tbx_station_name.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_station_name.Location = New System.Drawing.Point(279, 68)
        Me.tbx_station_name.Name = "tbx_station_name"
        Me.tbx_station_name.Size = New System.Drawing.Size(230, 22)
        Me.tbx_station_name.TabIndex = 92
        '
        'btn_update_station
        '
        Me.btn_update_station.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_update_station.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_update_station.FlatAppearance.BorderSize = 0
        Me.btn_update_station.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_update_station.Location = New System.Drawing.Point(521, 65)
        Me.btn_update_station.Name = "btn_update_station"
        Me.btn_update_station.Size = New System.Drawing.Size(115, 25)
        Me.btn_update_station.TabIndex = 89
        Me.btn_update_station.Text = "UPDATE"
        Me.btn_update_station.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_update_station.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(275, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(106, 17)
        Me.Label19.TabIndex = 86
        Me.Label19.Text = "STATION NAME"
        '
        'get_station
        '
        Me.get_station.BackColor = System.Drawing.Color.DarkBlue
        Me.get_station.FlatAppearance.BorderSize = 0
        Me.get_station.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.get_station.Location = New System.Drawing.Point(129, 65)
        Me.get_station.Name = "get_station"
        Me.get_station.Size = New System.Drawing.Size(114, 25)
        Me.get_station.TabIndex = 85
        Me.get_station.Text = "GET"
        Me.get_station.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.get_station.UseVisualStyleBackColor = False
        '
        'tbx_stations_id
        '
        Me.tbx_stations_id.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_stations_id.Location = New System.Drawing.Point(13, 66)
        Me.tbx_stations_id.Name = "tbx_stations_id"
        Me.tbx_stations_id.Size = New System.Drawing.Size(110, 22)
        Me.tbx_stations_id.TabIndex = 84
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tw Cen MT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(10, 46)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(20, 17)
        Me.Label20.TabIndex = 83
        Me.Label20.Text = "ID"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(20, 389)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "INFORMATION"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(744, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 31)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "RAIL MAP"
        '
        'stop_btn_1
        '
        Me.stop_btn_1.BackColor = System.Drawing.Color.White
        Me.stop_btn_1.Location = New System.Drawing.Point(1039, 165)
        Me.stop_btn_1.Name = "stop_btn_1"
        Me.stop_btn_1.Size = New System.Drawing.Size(22, 23)
        Me.stop_btn_1.TabIndex = 6
        Me.stop_btn_1.Text = "!"
        Me.stop_btn_1.UseVisualStyleBackColor = False
        Me.stop_btn_1.Visible = False
        '
        'stop_btn_2
        '
        Me.stop_btn_2.BackColor = System.Drawing.Color.White
        Me.stop_btn_2.Location = New System.Drawing.Point(773, 88)
        Me.stop_btn_2.Name = "stop_btn_2"
        Me.stop_btn_2.Size = New System.Drawing.Size(22, 23)
        Me.stop_btn_2.TabIndex = 7
        Me.stop_btn_2.Text = "!"
        Me.stop_btn_2.UseVisualStyleBackColor = False
        Me.stop_btn_2.Visible = False
        '
        'stop_btn_3
        '
        Me.stop_btn_3.BackColor = System.Drawing.Color.White
        Me.stop_btn_3.Location = New System.Drawing.Point(841, 87)
        Me.stop_btn_3.Name = "stop_btn_3"
        Me.stop_btn_3.Size = New System.Drawing.Size(22, 23)
        Me.stop_btn_3.TabIndex = 8
        Me.stop_btn_3.Text = "!"
        Me.stop_btn_3.UseVisualStyleBackColor = False
        Me.stop_btn_3.Visible = False
        '
        'stop_btn_4
        '
        Me.stop_btn_4.BackColor = System.Drawing.Color.White
        Me.stop_btn_4.Location = New System.Drawing.Point(936, 89)
        Me.stop_btn_4.Name = "stop_btn_4"
        Me.stop_btn_4.Size = New System.Drawing.Size(22, 23)
        Me.stop_btn_4.TabIndex = 9
        Me.stop_btn_4.Text = "!"
        Me.stop_btn_4.UseVisualStyleBackColor = False
        Me.stop_btn_4.Visible = False
        '
        'stop_btn_5
        '
        Me.stop_btn_5.BackColor = System.Drawing.Color.White
        Me.stop_btn_5.Location = New System.Drawing.Point(1061, 198)
        Me.stop_btn_5.Name = "stop_btn_5"
        Me.stop_btn_5.Size = New System.Drawing.Size(22, 23)
        Me.stop_btn_5.TabIndex = 10
        Me.stop_btn_5.Text = "!"
        Me.stop_btn_5.UseVisualStyleBackColor = False
        Me.stop_btn_5.Visible = False
        '
        'stop_btn_6
        '
        Me.stop_btn_6.BackColor = System.Drawing.Color.White
        Me.stop_btn_6.Location = New System.Drawing.Point(1118, 253)
        Me.stop_btn_6.Name = "stop_btn_6"
        Me.stop_btn_6.Size = New System.Drawing.Size(22, 23)
        Me.stop_btn_6.TabIndex = 11
        Me.stop_btn_6.Text = "!"
        Me.stop_btn_6.UseVisualStyleBackColor = False
        Me.stop_btn_6.Visible = False
        '
        'stop_btn_7
        '
        Me.stop_btn_7.BackColor = System.Drawing.Color.White
        Me.stop_btn_7.Location = New System.Drawing.Point(1177, 313)
        Me.stop_btn_7.Name = "stop_btn_7"
        Me.stop_btn_7.Size = New System.Drawing.Size(22, 23)
        Me.stop_btn_7.TabIndex = 12
        Me.stop_btn_7.Text = "!"
        Me.stop_btn_7.UseVisualStyleBackColor = False
        Me.stop_btn_7.Visible = False
        '
        'stop_btn_8
        '
        Me.stop_btn_8.BackColor = System.Drawing.Color.White
        Me.stop_btn_8.Location = New System.Drawing.Point(1144, 79)
        Me.stop_btn_8.Name = "stop_btn_8"
        Me.stop_btn_8.Size = New System.Drawing.Size(22, 23)
        Me.stop_btn_8.TabIndex = 13
        Me.stop_btn_8.Text = "!"
        Me.stop_btn_8.UseVisualStyleBackColor = False
        Me.stop_btn_8.Visible = False
        '
        'stop_btn_9
        '
        Me.stop_btn_9.BackColor = System.Drawing.Color.White
        Me.stop_btn_9.Location = New System.Drawing.Point(1039, 67)
        Me.stop_btn_9.Name = "stop_btn_9"
        Me.stop_btn_9.Size = New System.Drawing.Size(22, 23)
        Me.stop_btn_9.TabIndex = 14
        Me.stop_btn_9.Text = "!"
        Me.stop_btn_9.UseVisualStyleBackColor = False
        Me.stop_btn_9.Visible = False
        '
        'stop_btn_10
        '
        Me.stop_btn_10.BackColor = System.Drawing.Color.White
        Me.stop_btn_10.Location = New System.Drawing.Point(828, 203)
        Me.stop_btn_10.Name = "stop_btn_10"
        Me.stop_btn_10.Size = New System.Drawing.Size(22, 23)
        Me.stop_btn_10.TabIndex = 15
        Me.stop_btn_10.Text = "!"
        Me.stop_btn_10.UseVisualStyleBackColor = False
        Me.stop_btn_10.Visible = False
        '
        'stop_btn_11
        '
        Me.stop_btn_11.BackColor = System.Drawing.Color.White
        Me.stop_btn_11.Location = New System.Drawing.Point(944, 304)
        Me.stop_btn_11.Name = "stop_btn_11"
        Me.stop_btn_11.Size = New System.Drawing.Size(22, 23)
        Me.stop_btn_11.TabIndex = 16
        Me.stop_btn_11.Text = "!"
        Me.stop_btn_11.UseVisualStyleBackColor = False
        Me.stop_btn_11.Visible = False
        '
        'stop_btn_12
        '
        Me.stop_btn_12.BackColor = System.Drawing.Color.White
        Me.stop_btn_12.Location = New System.Drawing.Point(885, 339)
        Me.stop_btn_12.Name = "stop_btn_12"
        Me.stop_btn_12.Size = New System.Drawing.Size(22, 23)
        Me.stop_btn_12.TabIndex = 17
        Me.stop_btn_12.Text = "!"
        Me.stop_btn_12.UseVisualStyleBackColor = False
        Me.stop_btn_12.Visible = False
        '
        'stop_btn_13
        '
        Me.stop_btn_13.BackColor = System.Drawing.Color.White
        Me.stop_btn_13.Location = New System.Drawing.Point(1095, 225)
        Me.stop_btn_13.Name = "stop_btn_13"
        Me.stop_btn_13.Size = New System.Drawing.Size(22, 23)
        Me.stop_btn_13.TabIndex = 18
        Me.stop_btn_13.Text = "!"
        Me.stop_btn_13.UseVisualStyleBackColor = False
        Me.stop_btn_13.Visible = False
        '
        'stop_btn_14
        '
        Me.stop_btn_14.BackColor = System.Drawing.Color.White
        Me.stop_btn_14.Location = New System.Drawing.Point(816, 247)
        Me.stop_btn_14.Name = "stop_btn_14"
        Me.stop_btn_14.Size = New System.Drawing.Size(22, 23)
        Me.stop_btn_14.TabIndex = 19
        Me.stop_btn_14.Text = "!"
        Me.stop_btn_14.UseVisualStyleBackColor = False
        Me.stop_btn_14.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Firebrick
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(1143, 392)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 25)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "RESET"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_mon
        '
        Me.btn_mon.BackColor = System.Drawing.Color.DimGray
        Me.btn_mon.Font = New System.Drawing.Font("Tw Cen MT", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mon.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_mon.Location = New System.Drawing.Point(11, 12)
        Me.btn_mon.Name = "btn_mon"
        Me.btn_mon.Size = New System.Drawing.Size(85, 28)
        Me.btn_mon.TabIndex = 91
        Me.btn_mon.Text = "MONDAY"
        Me.btn_mon.UseVisualStyleBackColor = False
        '
        'btn_wed
        '
        Me.btn_wed.BackColor = System.Drawing.Color.DimGray
        Me.btn_wed.Font = New System.Drawing.Font("Tw Cen MT", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_wed.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_wed.Location = New System.Drawing.Point(199, 12)
        Me.btn_wed.Name = "btn_wed"
        Me.btn_wed.Size = New System.Drawing.Size(85, 28)
        Me.btn_wed.TabIndex = 92
        Me.btn_wed.Text = "WEDNESDAY"
        Me.btn_wed.UseVisualStyleBackColor = False
        '
        'btn_tue
        '
        Me.btn_tue.BackColor = System.Drawing.Color.DimGray
        Me.btn_tue.Font = New System.Drawing.Font("Tw Cen MT", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tue.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_tue.Location = New System.Drawing.Point(105, 12)
        Me.btn_tue.Name = "btn_tue"
        Me.btn_tue.Size = New System.Drawing.Size(85, 28)
        Me.btn_tue.TabIndex = 93
        Me.btn_tue.Text = "TUESDAY"
        Me.btn_tue.UseVisualStyleBackColor = False
        '
        'btn_sat
        '
        Me.btn_sat.BackColor = System.Drawing.Color.DimGray
        Me.btn_sat.Font = New System.Drawing.Font("Tw Cen MT", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_sat.Location = New System.Drawing.Point(199, 46)
        Me.btn_sat.Name = "btn_sat"
        Me.btn_sat.Size = New System.Drawing.Size(85, 28)
        Me.btn_sat.TabIndex = 94
        Me.btn_sat.Text = "SATURDAY"
        Me.btn_sat.UseVisualStyleBackColor = False
        '
        'btn_fri
        '
        Me.btn_fri.BackColor = System.Drawing.Color.DimGray
        Me.btn_fri.Font = New System.Drawing.Font("Tw Cen MT", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fri.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_fri.Location = New System.Drawing.Point(105, 46)
        Me.btn_fri.Name = "btn_fri"
        Me.btn_fri.Size = New System.Drawing.Size(85, 28)
        Me.btn_fri.TabIndex = 96
        Me.btn_fri.Text = "FRIDAY"
        Me.btn_fri.UseVisualStyleBackColor = False
        '
        'btn_thu
        '
        Me.btn_thu.BackColor = System.Drawing.Color.DimGray
        Me.btn_thu.Font = New System.Drawing.Font("Tw Cen MT", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_thu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_thu.Location = New System.Drawing.Point(11, 46)
        Me.btn_thu.Name = "btn_thu"
        Me.btn_thu.Size = New System.Drawing.Size(85, 28)
        Me.btn_thu.TabIndex = 95
        Me.btn_thu.Text = "THURSDAY"
        Me.btn_thu.UseVisualStyleBackColor = False
        '
        'btn_sun
        '
        Me.btn_sun.BackColor = System.Drawing.Color.DimGray
        Me.btn_sun.Font = New System.Drawing.Font("Tw Cen MT", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sun.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_sun.Location = New System.Drawing.Point(105, 81)
        Me.btn_sun.Name = "btn_sun"
        Me.btn_sun.Size = New System.Drawing.Size(85, 28)
        Me.btn_sun.TabIndex = 97
        Me.btn_sun.Text = "SUNDAY"
        Me.btn_sun.UseVisualStyleBackColor = False
        '
        'day_list
        '
        Me.day_list.FormattingEnabled = True
        Me.day_list.ItemHeight = 17
        Me.day_list.Location = New System.Drawing.Point(412, 255)
        Me.day_list.Name = "day_list"
        Me.day_list.Size = New System.Drawing.Size(293, 72)
        Me.day_list.TabIndex = 86
        Me.day_list.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tw Cen MT", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(412, 247)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(190, 14)
        Me.Label18.TabIndex = 87
        Me.Label18.Text = "! Only assign days after adding the Train"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1227, 661)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.stop_btn_14)
        Me.Controls.Add(Me.stop_btn_13)
        Me.Controls.Add(Me.stop_btn_12)
        Me.Controls.Add(Me.stop_btn_11)
        Me.Controls.Add(Me.stop_btn_10)
        Me.Controls.Add(Me.stop_btn_9)
        Me.Controls.Add(Me.stop_btn_8)
        Me.Controls.Add(Me.stop_btn_7)
        Me.Controls.Add(Me.stop_btn_6)
        Me.Controls.Add(Me.stop_btn_5)
        Me.Controls.Add(Me.stop_btn_4)
        Me.Controls.Add(Me.stop_btn_3)
        Me.Controls.Add(Me.stop_btn_2)
        Me.Controls.Add(Me.stop_btn_1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "VIA TRAINA TRAIN DATABASE"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.trips.ResumeLayout(False)
        Me.trips.PerformLayout()
        Me.routes.ResumeLayout(False)
        Me.routes.PerformLayout()
        Me.trains.ResumeLayout(False)
        Me.trains.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.stations.ResumeLayout(False)
        Me.stations.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents trips As System.Windows.Forms.TabPage
    Friend WithEvents routes As System.Windows.Forms.TabPage
    Friend WithEvents trains As System.Windows.Forms.TabPage
    Friend WithEvents stations As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents trip_route As System.Windows.Forms.Label
    Friend WithEvents trip_train As System.Windows.Forms.Label
    Friend WithEvents trip_id As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents trip_dep_time As System.Windows.Forms.Label
    Friend WithEvents trip_des As System.Windows.Forms.Label
    Friend WithEvents trip_arr_time As System.Windows.Forms.Label
    Friend WithEvents trip_hours As System.Windows.Forms.Label
    Friend WithEvents trip_day As System.Windows.Forms.Label
    Friend WithEvents trip_source As System.Windows.Forms.Label
    Friend WithEvents trip_selected_train As System.Windows.Forms.ComboBox
    Friend WithEvents trip_selected_route As System.Windows.Forms.ComboBox
    Friend WithEvents trip_arr As System.Windows.Forms.ComboBox
    Friend WithEvents trip_selected_hours As System.Windows.Forms.ComboBox
    Friend WithEvents trip_selected_day As System.Windows.Forms.ComboBox
    Friend WithEvents trip_to As System.Windows.Forms.ComboBox
    Friend WithEvents trip_from As System.Windows.Forms.ComboBox
    Friend WithEvents trip_dep As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox11 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox12 As System.Windows.Forms.ComboBox
    Friend WithEvents get_trip As System.Windows.Forms.Button
    Friend WithEvents add As System.Windows.Forms.Button
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents stop_btn_1 As System.Windows.Forms.Button
    Friend WithEvents stop_btn_2 As System.Windows.Forms.Button
    Friend WithEvents stop_btn_3 As System.Windows.Forms.Button
    Friend WithEvents stop_btn_4 As System.Windows.Forms.Button
    Friend WithEvents stop_btn_5 As System.Windows.Forms.Button
    Friend WithEvents stop_btn_6 As System.Windows.Forms.Button
    Friend WithEvents stop_btn_7 As System.Windows.Forms.Button
    Friend WithEvents stop_btn_8 As System.Windows.Forms.Button
    Friend WithEvents stop_btn_9 As System.Windows.Forms.Button
    Friend WithEvents stop_btn_10 As System.Windows.Forms.Button
    Friend WithEvents stop_btn_11 As System.Windows.Forms.Button
    Friend WithEvents stop_btn_12 As System.Windows.Forms.Button
    Friend WithEvents stop_btn_13 As System.Windows.Forms.Button
    Friend WithEvents stop_btn_14 As System.Windows.Forms.Button
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_get_route As System.Windows.Forms.Button
    Friend WithEvents tbx_route_id As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbx_route_end As System.Windows.Forms.ComboBox
    Friend WithEvents tbx_route_start As System.Windows.Forms.ComboBox
    Friend WithEvents tbx_route_name As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents active_trains As System.Windows.Forms.ListBox
    Friend WithEvents bounds As System.Windows.Forms.ListBox
    Friend WithEvents boundaries As System.Windows.Forms.Label
    Friend WithEvents reset_routes As System.Windows.Forms.Button
    Friend WithEvents route_add As System.Windows.Forms.Button
    Friend WithEvents route_delete As System.Windows.Forms.Button
    Friend WithEvents route_update As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents add_train As System.Windows.Forms.Button
    Friend WithEvents delete_train As System.Windows.Forms.Button
    Friend WithEvents update_train As System.Windows.Forms.Button
    Friend WithEvents cbx_train_route As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents get_set_trains As System.Windows.Forms.Button
    Friend WithEvents tbx_train_id As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tbx_train_name As System.Windows.Forms.TextBox
    Friend WithEvents reset_trains As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents tbx_station_name As System.Windows.Forms.TextBox
    Friend WithEvents btn_update_station As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents get_station As System.Windows.Forms.Button
    Friend WithEvents tbx_stations_id As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents part_of_route_list As System.Windows.Forms.ListBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_sun As System.Windows.Forms.Button
    Friend WithEvents btn_mon As System.Windows.Forms.Button
    Friend WithEvents btn_sat As System.Windows.Forms.Button
    Friend WithEvents btn_wed As System.Windows.Forms.Button
    Friend WithEvents btn_fri As System.Windows.Forms.Button
    Friend WithEvents btn_tue As System.Windows.Forms.Button
    Friend WithEvents btn_thu As System.Windows.Forms.Button
    Friend WithEvents day_list As System.Windows.Forms.ListBox
    Friend WithEvents Label18 As System.Windows.Forms.Label

End Class
