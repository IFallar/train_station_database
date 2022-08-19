Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Form1

    Dim tablemode As Integer = 1

    Dim id As String
    Dim train_name As String
    Dim route As String
    Dim route_id As Integer

    Dim trip_id_default
    Dim station_name_tags As New List(Of String)()

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT route.route_name FROM(route)"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim route_option = cmdreader.GetString("route_name")
            trip_selected_route.Items.Add(route_option)
            tbx_route_name.Items.Add(route_option)
            cbx_train_route.Items.Add(route_option)
        End While

        cmdreader.Close()

        con.Close()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT operating_days.day_name FROM(operating_days)"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim day_option = cmdreader.GetString("day_name")
        End While

        cmdreader.Close()

        con.Close()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT stations.station_name FROM(stations)"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim stations_option = cmdreader.GetString("station_name")
            tbx_route_start.Items.Add(stations_option)
            tbx_route_end.Items.Add(stations_option)
        End While

        cmdreader.Close()

        con.Close()




        tableload("SELECT ID, route.route_name AS ROUTE, train.train_name AS TRAIN, operating_days.day_name AS DAY, src.station_name AS ORIGIN, des.station_name AS DESTINATION, hrs.hours AS HOURS, arr.arrival_time AS ARRIVES, dpt.departure_time AS DEPARTS FROM trip INNER JOIN route ON trip.ROUTE = route.route_id INNER JOIN train ON trip.TRAIN = train.train_id INNER JOIN operating_days ON trip.DAY = operating_days.day_id INNER JOIN time_slots AS hrs ON trip.ARRIVAL = hrs.slot_id INNER JOIN time_slots AS arr ON trip.ARRIVAL = arr.slot_id INNER JOIN time_slots AS dpt ON trip.DEPARTURE = dpt.slot_id INNER JOIN stations AS src ON trip.ORIGIN = src.station_id INNER JOIN stations AS des ON trip.DESTINATION = des.station_id ORDER BY ID", DataGridView1)
        strconn.Close()

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
         Handles TabControl1.SelectedIndexChanged

        'tab index changer
        If TabControl1.SelectedIndex = 0 Then
            tableload("SELECT ID, route.route_name AS ROUTE, train.train_name AS TRAIN, operating_days.day_name AS DAY, src.station_name AS ORIGIN, des.station_name AS DESTINATION, hrs.hours AS HOURS, arr.arrival_time AS ARRIVES, dpt.departure_time AS DEPARTS FROM trip INNER JOIN route ON trip.ROUTE = route.route_id INNER JOIN train ON trip.TRAIN = train.train_id INNER JOIN operating_days ON trip.DAY = operating_days.day_id INNER JOIN time_slots AS hrs ON trip.ARRIVAL = hrs.slot_id INNER JOIN time_slots AS arr ON trip.ARRIVAL = arr.slot_id INNER JOIN time_slots AS dpt ON trip.DEPARTURE = dpt.slot_id INNER JOIN stations AS src ON trip.ORIGIN = src.station_id INNER JOIN stations AS des ON trip.DESTINATION = des.station_id ORDER BY ID", DataGridView1)
            strconn.Close()

        ElseIf TabControl1.SelectedIndex = 1 Then
            tableload("SELECT route.route_id AS ID, route.route_name AS NAME, src.station_name AS ORIGIN, des.station_name AS END FROM(route) INNER JOIN stations AS src ON route.starts_at_station  = src.station_id INNER JOIN stations AS des ON route.ends_at_station  = des.station_id ORDER BY ID", DataGridView1)
            strconn.Close()

        ElseIf TabControl1.SelectedIndex = 2 Then
            tableload("SELECT train.train_id AS ID, train.train_name AS NAME, route.route_name AS ROUTE FROM(train) INNER JOIN route ON train.assigned_to = route.route_id ORDER BY ID", DataGridView1)
            strconn.Close()

        ElseIf TabControl1.SelectedIndex = 3 Then
            tableload("SELECT stations.station_id AS ID, stations.station_name AS NAME FROM(stations)", DataGridView1)
            strconn.Close()

        End If

    End Sub

    Dim select_route As String = 0

    Private Sub trip_selected_route_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trip_selected_route.SelectedIndexChanged

        stop_btn_1.Visible = False
        stop_btn_1.BackColor = Color.White
        stop_btn_2.Visible = False
        stop_btn_2.BackColor = Color.White
        stop_btn_3.Visible = False
        stop_btn_3.BackColor = Color.White
        stop_btn_4.Visible = False
        stop_btn_4.BackColor = Color.White
        stop_btn_5.Visible = False
        stop_btn_5.BackColor = Color.White
        stop_btn_6.Visible = False
        stop_btn_6.BackColor = Color.White
        stop_btn_7.Visible = False
        stop_btn_7.BackColor = Color.White

        stop_btn_8.Visible = False
        stop_btn_8.BackColor = Color.White
        stop_btn_9.Visible = False
        stop_btn_9.BackColor = Color.White
        stop_btn_10.Visible = False
        stop_btn_10.BackColor = Color.White
        stop_btn_11.Visible = False
        stop_btn_11.BackColor = Color.White
        stop_btn_12.Visible = False
        stop_btn_12.BackColor = Color.White

        stop_btn_13.Visible = False
        stop_btn_13.BackColor = Color.White
        stop_btn_14.Visible = False
        stop_btn_14.BackColor = Color.White

        Try
            Dim rd As MySqlDataReader
            Dim cmd As New MySqlCommand

            Dim route_id_ini As String = trip_selected_route.Text

            opencon()

            cmd.CommandText = "SELECT `route_id` FROM `route` WHERE route.route_name ='" & route_id_ini & "'"
            cmd.Connection = con

            rd = cmd.ExecuteReader

            If rd.Read Then

                select_route = rd.GetValue(0)

            End If

            rd.Close()
            con.Close()

        Catch ex As Exception

        End Try

        con.Close()

        trip_selected_train.ResetText()
        trip_selected_train.Items.Clear()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT train.train_name FROM(train) WHERE train.assigned_to = '" & select_route & "'"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim train_option = cmdreader.GetString("train_name")
            trip_selected_train.Items.Add(train_option)
        End While

        cmdreader.Close()

        con.Close()

        'Setting Origin and Destination Options

        trip_from.ResetText()
        trip_to.ResetText()
        trip_from.Items.Clear()
        trip_to.Items.Clear()

        opencon()

        cmd.Connection = con
        If trip_selected_route.SelectedIndex > 2 Then
            cmd.CommandText = "SELECT stations.station_name FROM(stations)"
        Else
            cmd.CommandText = "SELECT stations.station_name FROM route_stations INNER JOIN stations ON stations.station_id = route_stations.part_station_id WHERE route_stations.part_of_route_id = '" & select_route & "'"
        End If
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim station_options = cmdreader.GetString("station_name")
            trip_from.Items.Add(station_options)
            trip_to.Items.Add(station_options)
        End While

        cmdreader.Close()

        con.Close()

    End Sub

    Dim select_train As Integer = 0

    Private Sub trip_selected_train_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trip_selected_train.SelectedIndexChanged

        Try
            Dim rd As MySqlDataReader
            Dim cmd As New MySqlCommand

            Dim train_id_ini As String = trip_selected_train.Text

            opencon()

            cmd.CommandText = "SELECT `train_id` FROM `train` WHERE train.train_name ='" & train_id_ini & "'"
            cmd.Connection = con

            rd = cmd.ExecuteReader

            If rd.Read Then

                select_train = rd.GetValue(0)

            End If

            rd.Close()
            con.Close()

        Catch ex As Exception

        End Try

        con.Close()

        trip_selected_day.ResetText()
        trip_selected_day.Items.Clear()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT operating_days.day_name FROM train_days INNER JOIN operating_days ON operating_days.day_id = train_days.working_day WHERE train_days.working_train = '" & select_train & "' ORDER BY day_id "
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim day_option = cmdreader.GetString("day_name")
            trip_selected_day.Items.Add(day_option)
        End While

        cmdreader.Close()

        con.Close()

    End Sub

    Dim select_hour As String = ""

    Private Sub trip_selected_hours_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trip_selected_hours.SelectedIndexChanged

        If Me.trip_selected_hours.SelectedIndex = 0 Then
            select_hour = "MORNING"

        ElseIf Me.trip_selected_hours.SelectedIndex = 1 Then
            select_hour = "MIDDAY"

        ElseIf Me.trip_selected_hours.SelectedIndex = 2 Then
            select_hour = "AFTERNOON"

        ElseIf Me.trip_selected_hours.SelectedIndex = 3 Then
            select_hour = "EVENING"

        End If

        trip_arr.ResetText()
        trip_arr.Items.Clear()
        trip_dep.ResetText()
        trip_dep.Items.Clear()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT `arrival_time`, `departure_time`, `hours` FROM `time_slots` WHERE time_slots.hours ='" & select_hour & "'"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim time_option = cmdreader.GetString("arrival_time")
            trip_arr.Items.Add(time_option)

        End While

        cmdreader.Close()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim time_option_dep = cmdreader.GetString("departure_time")
            trip_dep.Items.Add(time_option_dep)

        End While

        cmdreader.Close()

        con.Close()
    End Sub

    Private Sub trip_arr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trip_arr.SelectedIndexChanged

        con.Close()

        Dim arr_time = trip_arr.Text

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT `slot_id`, `departure_time`, `hours` FROM `time_slots` WHERE time_slots.arrival_time ='" & arr_time & "' AND time_slots.hours ='" & select_hour & "'"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim time_option_dep = cmdreader.GetString("departure_time")
            trip_dep.Text = time_option_dep
        End While

        cmdreader.Close()

        con.Close()

    End Sub

    Private Sub trip_from_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trip_from.SelectedIndexChanged

        opencon()

        trip_to.Items.Clear()

        cmd.Connection = con
        cmd.CommandText = "SELECT stations.station_name FROM route_stations INNER JOIN stations ON stations.station_id = route_stations.part_station_id WHERE route_stations.part_of_route_id = '" & select_route & "'"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim station_options = cmdreader.GetString("station_name")
            trip_to.Items.Add(station_options)
        End While

        cmdreader.Close()

        con.Close()

        Dim from = trip_from.Text
        trip_to.Items.Remove(from)

        stop_btn_1.Visible = False
        stop_btn_1.BackColor = Color.White
        stop_btn_2.Visible = False
        stop_btn_2.BackColor = Color.White
        stop_btn_3.Visible = False
        stop_btn_3.BackColor = Color.White
        stop_btn_4.Visible = False
        stop_btn_4.BackColor = Color.White
        stop_btn_5.Visible = False
        stop_btn_5.BackColor = Color.White
        stop_btn_6.Visible = False
        stop_btn_6.BackColor = Color.White
        stop_btn_7.Visible = False
        stop_btn_7.BackColor = Color.White

        stop_btn_8.Visible = False
        stop_btn_8.BackColor = Color.White
        stop_btn_9.Visible = False
        stop_btn_9.BackColor = Color.White
        stop_btn_10.Visible = False
        stop_btn_10.BackColor = Color.White
        stop_btn_11.Visible = False
        stop_btn_11.BackColor = Color.White
        stop_btn_12.Visible = False
        stop_btn_12.BackColor = Color.White

        stop_btn_13.Visible = False
        stop_btn_13.BackColor = Color.White
        stop_btn_14.Visible = False
        stop_btn_14.BackColor = Color.White

        Select Case trip_from.Text

            Case "Central Station"
                stop_btn_1.Visible = True
                stop_btn_1.BackColor = Color.Green
            Case "Cornelia Station"
                stop_btn_2.Visible = True
                stop_btn_2.BackColor = Color.Green
            Case "Valle Aurelia"
                stop_btn_3.Visible = True
                stop_btn_3.BackColor = Color.Green
            Case "Lepanto Station"
                stop_btn_4.Visible = True
                stop_btn_4.BackColor = Color.Green
            Case "Vittorio Station"
                stop_btn_5.Visible = True
                stop_btn_5.BackColor = Color.Green
            Case "Agricola Station"
                stop_btn_6.Visible = True
                stop_btn_6.BackColor = Color.Green
            Case "Travertino Station"
                stop_btn_7.Visible = True
                stop_btn_7.BackColor = Color.Green
            Case "Quintilianni Station"
                stop_btn_8.Visible = True
                stop_btn_8.BackColor = Color.Green
            Case "Magliana Station"
                stop_btn_9.Visible = True
                stop_btn_9.BackColor = Color.Green
            Case "Pretorio Station"
                stop_btn_10.Visible = True
                stop_btn_10.BackColor = Color.Green
            Case "Massimo Station"
                stop_btn_11.Visible = True
                stop_btn_11.BackColor = Color.Green
            Case "Laurentina Station"
                stop_btn_12.Visible = True
                stop_btn_12.BackColor = Color.Green
            Case "Manzoni Station"
                stop_btn_13.Visible = True
                stop_btn_13.BackColor = Color.Green
            Case "Airport Station"
                stop_btn_14.Visible = True
                stop_btn_14.BackColor = Color.Green
            Case Else

        End Select

        Select Case trip_to.Text

            Case "Central Station"
                stop_btn_1.Visible = True
                stop_btn_1.BackColor = Color.DarkRed
            Case "Cornelia Station"
                stop_btn_2.Visible = True
                stop_btn_2.BackColor = Color.DarkRed
            Case "Valle Aurelia"
                stop_btn_3.Visible = True
                stop_btn_3.BackColor = Color.DarkRed
            Case "Lepanto Station"
                stop_btn_4.Visible = True
                stop_btn_4.BackColor = Color.DarkRed
            Case "Vittorio Station"
                stop_btn_5.Visible = True
                stop_btn_5.BackColor = Color.DarkRed
            Case "Agricola Station"
                stop_btn_6.Visible = True
                stop_btn_6.BackColor = Color.DarkRed
            Case "Travertino Station"
                stop_btn_7.Visible = True
                stop_btn_7.BackColor = Color.DarkRed
            Case "Quintilianni Station"
                stop_btn_8.Visible = True
                stop_btn_8.BackColor = Color.DarkRed
            Case "Magliana Station"
                stop_btn_9.Visible = True
                stop_btn_9.BackColor = Color.DarkRed
            Case "Pretorio Station"
                stop_btn_10.Visible = True
                stop_btn_10.BackColor = Color.DarkRed
            Case "Massimo Station"
                stop_btn_11.Visible = True
                stop_btn_11.BackColor = Color.DarkRed
            Case "Laurentina Station"
                stop_btn_12.Visible = True
                stop_btn_12.BackColor = Color.DarkRed
            Case "Manzoni Station"
                stop_btn_13.Visible = True
                stop_btn_13.BackColor = Color.DarkRed
            Case "Airport Station"
                stop_btn_14.Visible = True
                stop_btn_14.BackColor = Color.DarkRed
            Case Else


        End Select

    End Sub

    Private Sub trip_to_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trip_to.SelectedIndexChanged

        opencon()

        trip_from.Items.Clear()

        cmd.Connection = con
        cmd.CommandText = "SELECT stations.station_name FROM route_stations INNER JOIN stations ON stations.station_id = route_stations.part_station_id WHERE route_stations.part_of_route_id = '" & select_route & "'"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim station_options = cmdreader.GetString("station_name")
            trip_from.Items.Add(station_options)
        End While

        cmdreader.Close()

        con.Close()

        Dim station_to = trip_to.Text
        trip_from.Items.Remove(station_to)

        stop_btn_1.Visible = False
        stop_btn_1.BackColor = Color.White
        stop_btn_2.Visible = False
        stop_btn_2.BackColor = Color.White
        stop_btn_3.Visible = False
        stop_btn_3.BackColor = Color.White
        stop_btn_4.Visible = False
        stop_btn_4.BackColor = Color.White
        stop_btn_5.Visible = False
        stop_btn_5.BackColor = Color.White
        stop_btn_6.Visible = False
        stop_btn_6.BackColor = Color.White
        stop_btn_7.Visible = False
        stop_btn_7.BackColor = Color.White

        stop_btn_8.Visible = False
        stop_btn_8.BackColor = Color.White
        stop_btn_9.Visible = False
        stop_btn_9.BackColor = Color.White
        stop_btn_10.Visible = False
        stop_btn_10.BackColor = Color.White
        stop_btn_11.Visible = False
        stop_btn_11.BackColor = Color.White
        stop_btn_12.Visible = False
        stop_btn_12.BackColor = Color.White

        stop_btn_13.Visible = False
        stop_btn_13.BackColor = Color.White
        stop_btn_14.Visible = False
        stop_btn_14.BackColor = Color.White

        Select Case trip_from.Text

            Case "Central Station"
                stop_btn_1.Visible = True
                stop_btn_1.BackColor = Color.Green
            Case "Cornelia Station"
                stop_btn_2.Visible = True
                stop_btn_2.BackColor = Color.Green
            Case "Valle Aurelia"
                stop_btn_3.Visible = True
                stop_btn_3.BackColor = Color.Green
            Case "Lepanto Station"
                stop_btn_4.Visible = True
                stop_btn_4.BackColor = Color.Green
            Case "Vittorio Station"
                stop_btn_5.Visible = True
                stop_btn_5.BackColor = Color.Green
            Case "Agricola Station"
                stop_btn_6.Visible = True
                stop_btn_6.BackColor = Color.Green
            Case "Travertino Station"
                stop_btn_7.Visible = True
                stop_btn_7.BackColor = Color.Green
            Case "Quintilianni Station"
                stop_btn_8.Visible = True
                stop_btn_8.BackColor = Color.Green
            Case "Magliana Station"
                stop_btn_9.Visible = True
                stop_btn_9.BackColor = Color.Green
            Case "Pretorio Station"
                stop_btn_10.Visible = True
                stop_btn_10.BackColor = Color.Green
            Case "Massimo Station"
                stop_btn_11.Visible = True
                stop_btn_11.BackColor = Color.Green
            Case "Laurentina Station"
                stop_btn_12.Visible = True
                stop_btn_12.BackColor = Color.Green
            Case "Manzoni Station"
                stop_btn_13.Visible = True
                stop_btn_13.BackColor = Color.Green
            Case "Airport Station"
                stop_btn_14.Visible = True
                stop_btn_14.BackColor = Color.Green
            Case Else

        End Select

        Select Case trip_to.Text

            Case "Central Station"
                stop_btn_1.Visible = True
                stop_btn_1.BackColor = Color.DarkRed
            Case "Cornelia Station"
                stop_btn_2.Visible = True
                stop_btn_2.BackColor = Color.DarkRed
            Case "Valle Aurelia"
                stop_btn_3.Visible = True
                stop_btn_3.BackColor = Color.DarkRed
            Case "Lepanto Station"
                stop_btn_4.Visible = True
                stop_btn_4.BackColor = Color.DarkRed
            Case "Vittorio Station"
                stop_btn_5.Visible = True
                stop_btn_5.BackColor = Color.DarkRed
            Case "Agricola Station"
                stop_btn_6.Visible = True
                stop_btn_6.BackColor = Color.DarkRed
            Case "Travertino Station"
                stop_btn_7.Visible = True
                stop_btn_7.BackColor = Color.DarkRed
            Case "Quintilianni Station"
                stop_btn_8.Visible = True
                stop_btn_8.BackColor = Color.DarkRed
            Case "Magliana Station"
                stop_btn_9.Visible = True
                stop_btn_9.BackColor = Color.DarkRed
            Case "Pretorio Station"
                stop_btn_10.Visible = True
                stop_btn_10.BackColor = Color.DarkRed
            Case "Massimo Station"
                stop_btn_11.Visible = True
                stop_btn_11.BackColor = Color.DarkRed
            Case "Laurentina Station"
                stop_btn_12.Visible = True
                stop_btn_12.BackColor = Color.DarkRed
            Case "Manzoni Station"
                stop_btn_13.Visible = True
                stop_btn_13.BackColor = Color.DarkRed
            Case "Airport Station"
                stop_btn_14.Visible = True
                stop_btn_14.BackColor = Color.DarkRed
            Case Else


        End Select


    End Sub

    'ADDING, UPDATING AND DELETING =============================================================================================================================

    Private Sub add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add.Click

        Dim route_id_final As String
        Dim train_id_final As String
        Dim day_id_final As String
        Dim slot_id_final As String
        Dim ori_id_final As String
        Dim des_id_final As String

        Try

            Dim rd As MySqlDataReader
            Dim cmd As New MySqlCommand

            '========================================================================================================

            Dim route_id_ini As String = trip_selected_route.Text


            opencon()

            cmd.CommandText = "SELECT `route_id` FROM `route` WHERE route.route_name ='" & route_id_ini & "'"
            cmd.Connection = con

            rd = cmd.ExecuteReader

            If rd.Read Then

                route_id_final = rd.GetValue(0)

            End If

            rd.Close()
            con.Close()

            '========================================================================================================
            '========================================================================================================

            Dim train_id_ini As String = trip_selected_train.Text


            opencon()

            cmd.CommandText = "SELECT `train_id` FROM `train` WHERE train.train_name ='" & train_id_ini & "'"
            cmd.Connection = con

            rd = cmd.ExecuteReader

            If rd.Read Then

                train_id_final = rd.GetValue(0)

            End If

            rd.Close()
            con.Close()

            '========================================================================================================
            '========================================================================================================

            Dim day_id_ini As String = trip_selected_day.Text


            opencon()

            cmd.CommandText = "SELECT `day_id` FROM `operating_days` WHERE operating_days.day_name ='" & day_id_ini & "'"
            cmd.Connection = con

            rd = cmd.ExecuteReader

            If rd.Read Then

                day_id_final = rd.GetValue(0)

            End If

            rd.Close()
            con.Close()

            '========================================================================================================
            '========================================================================================================

            Dim slot_id_ini As String = trip_arr.Text


            opencon()

            cmd.CommandText = "SELECT `slot_id` FROM `time_slots` WHERE time_slots.arrival_time ='" & slot_id_ini & "' AND time_slots.hours ='" & trip_selected_hours.Text & "'"
            cmd.Connection = con

            rd = cmd.ExecuteReader

            If rd.Read Then

                slot_id_final = rd.GetValue(0)

            End If

            rd.Close()
            con.Close()

            '========================================================================================================
            '========================================================================================================

            Dim ori_id_ini As String = trip_from.Text


            opencon()

            cmd.CommandText = "SELECT `station_id` FROM `stations` WHERE stations.station_name ='" & ori_id_ini & "'"
            cmd.Connection = con

            rd = cmd.ExecuteReader

            If rd.Read Then

                ori_id_final = rd.GetValue(0)

            End If

            rd.Close()
            con.Close()

            '========================================================================================================
            '========================================================================================================

            Dim des_id_ini As String = trip_to.Text


            opencon()

            cmd.CommandText = "SELECT `station_id` FROM `stations` WHERE stations.station_name ='" & des_id_ini & "'"
            cmd.Connection = con

            rd = cmd.ExecuteReader

            If rd.Read Then

                des_id_final = rd.GetValue(0)

            End If

            rd.Close()
            con.Close()

        Catch ex As Exception

        End Try

        '========================================================================================================

        strconnection()

        cmd.Connection = strconn
        strconn.Open()

        cmd.CommandText = "INSERT INTO `trip`(`ID`, `ROUTE`, `TRAIN`, `DAY`, `ARRIVAL`, `DEPARTURE`, `ORIGIN`, `DESTINATION`) VALUES (DEFAULT,'" & route_id_final & "','" & train_id_final & "','" & day_id_final & "','" & slot_id_final & "','" & slot_id_final & "','" & ori_id_final & "','" & des_id_final & "')"
        cmd.ExecuteNonQuery()
        MsgBox("New Trip Added")
        strconn.Close()

        tableload("SELECT ID, route.route_name AS ROUTE, train.train_name AS TRAIN, operating_days.day_name AS DAY, src.station_name AS ORIGIN, des.station_name AS DESTINATION, hrs.hours AS HOURS, arr.arrival_time AS ARRIVES, dpt.departure_time AS DEPARTS FROM trip INNER JOIN route ON trip.ROUTE = route.route_id INNER JOIN train ON trip.TRAIN = train.train_id INNER JOIN operating_days ON trip.DAY = operating_days.day_id INNER JOIN time_slots AS hrs ON trip.ARRIVAL = hrs.slot_id INNER JOIN time_slots AS arr ON trip.ARRIVAL = arr.slot_id INNER JOIN time_slots AS dpt ON trip.DEPARTURE = dpt.slot_id INNER JOIN stations AS src ON trip.ORIGIN = src.station_id INNER JOIN stations AS des ON trip.DESTINATION = des.station_id ORDER BY ID", DataGridView1)
        strconn.Close()


    End Sub

    Private Sub get_trip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles get_trip.Click

        Dim repeater = 0

        While repeater <= 10


            Dim rd As MySqlDataReader
            Dim cmd As New MySqlCommand


            Try

                '========================================================================================================

                Dim trip_route_val As String
                Dim trip_train_val As String
                Dim trip_day_val As String
                Dim trip_hours_val As String
                Dim trip_timearr_val As String
                Dim trip_timedep_val As String
                Dim trip_ori_val As String
                Dim trip_des_val As String

                opencon()

                cmd.CommandText = "SELECT ID, route.route_name AS ROUTE, train.train_name AS TRAIN, operating_days.day_name AS DAY, src.station_name AS ORIGIN, des.station_name AS DESTINATION, hrs.hours AS HOURS, arr.arrival_time AS ARRIVES, dpt.departure_time AS DEPARTS FROM trip INNER JOIN route ON trip.ROUTE = route.route_id INNER JOIN train ON trip.TRAIN = train.train_id INNER JOIN operating_days ON trip.DAY = operating_days.day_id INNER JOIN time_slots AS hrs ON trip.ARRIVAL = hrs.slot_id INNER JOIN time_slots AS arr ON trip.ARRIVAL = arr.slot_id INNER JOIN time_slots AS dpt ON trip.DEPARTURE = dpt.slot_id INNER JOIN stations AS src ON trip.ORIGIN = src.station_id INNER JOIN stations AS des ON trip.DESTINATION = des.station_id WHERE trip.ID ='" & trip_id.Text & "'"
                cmd.Connection = con

                rd = cmd.ExecuteReader

                While rd.Read

                    trip_route_val = rd.GetString(1)
                    trip_selected_route.Text = trip_route_val

                    trip_train_val = rd.GetString(2)
                    trip_selected_train.Text = trip_train_val

                    trip_day_val = rd.GetString(3)
                    trip_selected_day.Text = trip_day_val

                    trip_ori_val = rd.GetString(4)
                    trip_from.Text = trip_ori_val

                    trip_des_val = rd.GetString(5)
                    trip_to.Text = trip_des_val

                    trip_hours_val = rd.GetString(6)
                    trip_selected_hours.Text = trip_hours_val

                    trip_timearr_val = rd.GetString(7)
                    trip_arr.Text = trip_timearr_val

                    trip_timedep_val = rd.GetString(8)
                    trip_dep.Text = trip_timedep_val


                End While

                rd.Close()
                con.Close()

                '========================================================================================================
                '========================================================================================================

                Dim trip_route_id As Integer
                Dim trip_train_id As Integer
                Dim trip_hours_id As Integer

                opencon()

                cmd.CommandText = "SELECT `ID`, `ROUTE`, `TRAIN`, `ARRIVAL` FROM `trip` WHERE trip.ID ='" & trip_id.Text & "'"
                cmd.Connection = con

                rd = cmd.ExecuteReader

                While rd.Read

                    trip_route_id = rd.GetValue(1)
                    trip_train_id = rd.GetValue(2)
                    trip_hours_id = rd.GetValue(3)

                End While

                rd.Close()
                con.Close()

                '========================================================================================================

                opencon()

                trip_selected_train.Items.Clear()

                cmd.CommandText = "SELECT train.train_name FROM(train) WHERE train.assigned_to = '" & trip_route_id & "'"

                rd = cmd.ExecuteReader

                While rd.Read
                    Dim train_option = rd.GetString("train_name")
                    trip_selected_train.Items.Add(train_option)
                End While

                rd.Close()
                con.Close()

                '========================================================================================================

                opencon()

                trip_from.Items.Clear()
                trip_to.Items.Clear()

                cmd.CommandText = "SELECT stations.station_name FROM route_stations INNER JOIN stations ON stations.station_id = route_stations.part_station_id WHERE route_stations.part_of_route_id = '" & trip_route_id & "'"

                rd = cmd.ExecuteReader

                While rd.Read
                    Dim station_options = rd.GetString("station_name")
                    trip_from.Items.Add(station_options)
                    trip_to.Items.Add(station_options)
                End While

                Dim station_to = trip_ori_val
                trip_from.Items.Remove(station_to)
                Dim station_from = trip_des_val
                trip_to.Items.Remove(station_from)

                rd.Close()
                con.Close()

                '========================================================================================================

                opencon()

                trip_selected_day.Items.Clear()

                cmd.CommandText = "SELECT operating_days.day_name FROM train_days INNER JOIN operating_days ON operating_days.day_id = train_days.working_day WHERE train_days.working_train = '" & trip_train_id & "' ORDER BY day_id "

                rd = cmd.ExecuteReader

                While rd.Read
                    Dim day_option = rd.GetString("day_name")
                    trip_selected_day.Items.Add(day_option)
                End While

                rd.Close()
                con.Close()

                '========================================================================================================

                opencon()

                trip_arr.Items.Clear()
                trip_dep.Items.Clear()

                cmd.CommandText = "SELECT `arrival_time`, `departure_time` FROM time_slots WHERE time_slots.hours = '" & trip_hours_val & "'"

                rd = cmd.ExecuteReader

                While rd.Read
                    Dim arr_time_option = rd.GetString("arrival_time")
                    trip_arr.Items.Add(arr_time_option)
                End While

                rd.Close()

                rd = cmd.ExecuteReader

                While rd.Read

                    Dim dep_time_option = rd.GetString("departure_time")
                    trip_dep.Items.Add(dep_time_option)
                End While

                rd.Close()

                con.Close()


            Catch ex As Exception

            End Try

            con.Close()

            repeater = repeater + 1

        End While

        stop_btn_1.Visible = False
        stop_btn_1.BackColor = Color.White
        stop_btn_2.Visible = False
        stop_btn_2.BackColor = Color.White
        stop_btn_3.Visible = False
        stop_btn_3.BackColor = Color.White
        stop_btn_4.Visible = False
        stop_btn_4.BackColor = Color.White
        stop_btn_5.Visible = False
        stop_btn_5.BackColor = Color.White
        stop_btn_6.Visible = False
        stop_btn_6.BackColor = Color.White
        stop_btn_7.Visible = False
        stop_btn_7.BackColor = Color.White

        stop_btn_8.Visible = False
        stop_btn_8.BackColor = Color.White
        stop_btn_9.Visible = False
        stop_btn_9.BackColor = Color.White
        stop_btn_10.Visible = False
        stop_btn_10.BackColor = Color.White
        stop_btn_11.Visible = False
        stop_btn_11.BackColor = Color.White
        stop_btn_12.Visible = False
        stop_btn_12.BackColor = Color.White

        stop_btn_13.Visible = False
        stop_btn_13.BackColor = Color.White
        stop_btn_14.Visible = False
        stop_btn_14.BackColor = Color.White

        Select Case trip_from.Text

            Case "Central Station"
                stop_btn_1.Visible = True
                stop_btn_1.BackColor = Color.Green
            Case "Cornelia Station"
                stop_btn_2.Visible = True
                stop_btn_2.BackColor = Color.Green
            Case "Valle Aurelia"
                stop_btn_3.Visible = True
                stop_btn_3.BackColor = Color.Green
            Case "Lepanto Station"
                stop_btn_4.Visible = True
                stop_btn_4.BackColor = Color.Green
            Case "Vittorio Station"
                stop_btn_5.Visible = True
                stop_btn_5.BackColor = Color.Green
            Case "Agricola Station"
                stop_btn_6.Visible = True
                stop_btn_6.BackColor = Color.Green
            Case "Travertino Station"
                stop_btn_7.Visible = True
                stop_btn_7.BackColor = Color.Green
            Case "Quintilianni Station"
                stop_btn_8.Visible = True
                stop_btn_8.BackColor = Color.Green
            Case "Magliana Station"
                stop_btn_9.Visible = True
                stop_btn_9.BackColor = Color.Green
            Case "Pretorio Station"
                stop_btn_10.Visible = True
                stop_btn_10.BackColor = Color.Green
            Case "Massimo Station"
                stop_btn_11.Visible = True
                stop_btn_11.BackColor = Color.Green
            Case "Laurentina Station"
                stop_btn_12.Visible = True
                stop_btn_12.BackColor = Color.Green
            Case "Manzoni Station"
                stop_btn_13.Visible = True
                stop_btn_13.BackColor = Color.Green
            Case "Airport Station"
                stop_btn_14.Visible = True
                stop_btn_14.BackColor = Color.Green
            Case Else

        End Select

        Select Case trip_to.Text

            Case "Central Station"
                stop_btn_1.Visible = True
                stop_btn_1.BackColor = Color.DarkRed
            Case "Cornelia Station"
                stop_btn_2.Visible = True
                stop_btn_2.BackColor = Color.DarkRed
            Case "Valle Aurelia"
                stop_btn_3.Visible = True
                stop_btn_3.BackColor = Color.DarkRed
            Case "Lepanto Station"
                stop_btn_4.Visible = True
                stop_btn_4.BackColor = Color.DarkRed
            Case "Vittorio Station"
                stop_btn_5.Visible = True
                stop_btn_5.BackColor = Color.DarkRed
            Case "Agricola Station"
                stop_btn_6.Visible = True
                stop_btn_6.BackColor = Color.DarkRed
            Case "Travertino Station"
                stop_btn_7.Visible = True
                stop_btn_7.BackColor = Color.DarkRed
            Case "Quintilianni Station"
                stop_btn_8.Visible = True
                stop_btn_8.BackColor = Color.DarkRed
            Case "Magliana Station"
                stop_btn_9.Visible = True
                stop_btn_9.BackColor = Color.DarkRed
            Case "Pretorio Station"
                stop_btn_10.Visible = True
                stop_btn_10.BackColor = Color.DarkRed
            Case "Massimo Station"
                stop_btn_11.Visible = True
                stop_btn_11.BackColor = Color.DarkRed
            Case "Laurentina Station"
                stop_btn_12.Visible = True
                stop_btn_12.BackColor = Color.DarkRed
            Case "Manzoni Station"
                stop_btn_13.Visible = True
                stop_btn_13.BackColor = Color.DarkRed
            Case "Airport Station"
                stop_btn_14.Visible = True
                stop_btn_14.BackColor = Color.DarkRed
            Case Else


        End Select

    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click

        Dim route_id_final As String
        Dim train_id_final As String
        Dim day_id_final As String
        Dim slot_id_final As String
        Dim des_id_final As String
        Dim ori_id_final As String

        Try

            Dim rd As MySqlDataReader
            Dim cmd As New MySqlCommand


            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT `arrival_time`, `departure_time`, `hours` FROM `time_slots` WHERE time_slots.hours ='" & select_hour & "'"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                Dim time_option = cmdreader.GetString("arrival_time")

                trip_arr.Items.Add(time_option)

            End While

            cmdreader.Close()

            con.Close()

            Dim x As Integer = 0

            While x = 0

                '========================================================================================================


                Dim route_id_ini As String = trip_selected_route.Text

                opencon()

                cmd.CommandText = "SELECT `route_id` FROM `route` WHERE route.route_name ='" & route_id_ini & "'"
                cmd.Connection = con

                rd = cmd.ExecuteReader

                If rd.Read Then

                    route_id_final = rd.GetValue(0)

                End If

                rd.Close()
                con.Close()

                '========================================================================================================
                '========================================================================================================

                Dim train_id_ini As String = trip_selected_train.Text

                opencon()

                cmd.CommandText = "SELECT `train_id` FROM `train` WHERE train.train_name ='" & train_id_ini & "'"
                cmd.Connection = con

                rd = cmd.ExecuteReader

                If rd.Read Then

                    train_id_final = rd.GetValue(0)

                End If

                rd.Close()
                con.Close()

                '========================================================================================================
                '========================================================================================================

                Dim day_id_ini As String = trip_selected_day.Text

                opencon()

                cmd.CommandText = "SELECT `day_id` FROM `operating_days` WHERE operating_days.day_name ='" & day_id_ini & "'"
                cmd.Connection = con

                rd = cmd.ExecuteReader

                If rd.Read Then

                    day_id_final = rd.GetValue(0)

                End If

                rd.Close()
                con.Close()

                '========================================================================================================
                '========================================================================================================

                Dim slot_id_ini As String = trip_arr.Text

                opencon()

                cmd.CommandText = "SELECT `slot_id` FROM `time_slots` WHERE time_slots.arrival_time ='" & slot_id_ini & "' AND time_slots.hours ='" & trip_selected_hours.Text & "'"
                cmd.Connection = con

                rd = cmd.ExecuteReader

                If rd.Read Then

                    slot_id_final = rd.GetValue(0)

                End If

                rd.Close()
                con.Close()

                '========================================================================================================
                '========================================================================================================

                Dim ori_id_ini As String = trip_from.Text

                opencon()

                cmd.CommandText = "SELECT `station_id` FROM `stations` WHERE stations.station_name ='" & ori_id_ini & "'"
                cmd.Connection = con

                rd = cmd.ExecuteReader

                If rd.Read Then

                    ori_id_final = rd.GetValue(0)

                End If

                rd.Close()
                con.Close()

                '========================================================================================================
                '========================================================================================================

                Dim des_id_ini As String = trip_to.Text

                opencon()

                cmd.CommandText = "SELECT `station_id` FROM `stations` WHERE stations.station_name ='" & des_id_ini & "'"
                cmd.Connection = con

                rd = cmd.ExecuteReader

                If rd.Read Then

                    des_id_final = rd.GetValue(0)

                End If

                rd.Close()
                con.Close()

                '========================================================================================================
                x = 1

            End While

        Catch ex As Exception

        End Try

        strconnection()

        cmd.Connection = strconn
        strconn.Open()

        cmd.CommandText = "UPDATE `trip` SET `ROUTE`='" & route_id_final & "',`TRAIN`='" & train_id_final & "',`DAY`='" & day_id_final & "', `ARRIVAL`= '" & slot_id_final & "', `DEPARTURE`= '" & slot_id_final & "', `ORIGIN`= '" & ori_id_final & "', `DESTINATION`= '" & des_id_final & "' WHERE trip.ID ='" & trip_id.Text & "'"
        cmd.ExecuteNonQuery()
        MsgBox("Data Updated")
        strconn.Close()

        tableload("SELECT ID, route.route_name AS ROUTE, train.train_name AS TRAIN, operating_days.day_name AS DAY, src.station_name AS ORIGIN, des.station_name AS DESTINATION, hrs.hours AS HOURS, arr.arrival_time AS ARRIVES, dpt.departure_time AS DEPARTS FROM trip INNER JOIN route ON trip.ROUTE = route.route_id INNER JOIN train ON trip.TRAIN = train.train_id INNER JOIN operating_days ON trip.DAY = operating_days.day_id INNER JOIN time_slots AS hrs ON trip.ARRIVAL = hrs.slot_id INNER JOIN time_slots AS arr ON trip.ARRIVAL = arr.slot_id INNER JOIN time_slots AS dpt ON trip.DEPARTURE = dpt.slot_id INNER JOIN stations AS src ON trip.ORIGIN = src.station_id INNER JOIN stations AS des ON trip.DESTINATION = des.station_id ORDER BY ID", DataGridView1)
        strconn.Close()

    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click

        Try

            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.CommandText = "DELETE FROM `trip` WHERE trip.ID ='" & trip_id.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Deleted")
            strconn.Close()

            tableload("SELECT ID, route.route_name AS ROUTE, train.train_name AS TRAIN, operating_days.day_name AS DAY, src.station_name AS ORIGIN, des.station_name AS DESTINATION, hrs.hours AS HOURS, arr.arrival_time AS ARRIVES, dpt.departure_time AS DEPARTS FROM trip INNER JOIN route ON trip.ROUTE = route.route_id INNER JOIN train ON trip.TRAIN = train.train_id INNER JOIN operating_days ON trip.DAY = operating_days.day_id INNER JOIN time_slots AS hrs ON trip.ARRIVAL = hrs.slot_id INNER JOIN time_slots AS arr ON trip.ARRIVAL = arr.slot_id INNER JOIN time_slots AS dpt ON trip.DEPARTURE = dpt.slot_id INNER JOIN stations AS src ON trip.ORIGIN = src.station_id INNER JOIN stations AS des ON trip.DESTINATION = des.station_id ORDER BY ID", DataGridView1)
            strconn.Close()

        Catch ex As Exception

        End Try



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click

        trip_id.ResetText()

        trip_selected_route.ResetText()

        trip_selected_train.ResetText()
        trip_selected_train.Items.Clear()

        trip_from.ResetText()
        trip_from.Items.Clear()

        trip_to.ResetText()
        trip_to.Items.Clear()

        trip_selected_hours.ResetText()

        trip_selected_day.ResetText()
        trip_selected_day.Items.Clear()

        trip_arr.ResetText()
        trip_arr.Items.Clear()

        trip_dep.ResetText()
        trip_dep.Items.Clear()

        stop_btn_1.Visible = False
        stop_btn_1.BackColor = Color.White
        stop_btn_2.Visible = False
        stop_btn_2.BackColor = Color.White
        stop_btn_3.Visible = False
        stop_btn_3.BackColor = Color.White
        stop_btn_4.Visible = False
        stop_btn_4.BackColor = Color.White
        stop_btn_5.Visible = False
        stop_btn_5.BackColor = Color.White
        stop_btn_6.Visible = False
        stop_btn_6.BackColor = Color.White
        stop_btn_7.Visible = False
        stop_btn_7.BackColor = Color.White

        stop_btn_8.Visible = False
        stop_btn_8.BackColor = Color.White
        stop_btn_9.Visible = False
        stop_btn_9.BackColor = Color.White
        stop_btn_10.Visible = False
        stop_btn_10.BackColor = Color.White
        stop_btn_11.Visible = False
        stop_btn_11.BackColor = Color.White
        stop_btn_12.Visible = False
        stop_btn_12.BackColor = Color.White

        stop_btn_13.Visible = False
        stop_btn_13.BackColor = Color.White
        stop_btn_14.Visible = False
        stop_btn_14.BackColor = Color.White

    End Sub

    Dim id_time_set As String

    Private Sub ComboBox12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox12.SelectedIndexChanged

        Dim TimeSet = False

        opencon()
        cmd.Connection = con

        Select ComboBox12.SelectedIndex

            Case 0
                cmd.CommandText = "SELECT trip.ID FROM(trip)"
            Case 1
                cmd.CommandText = "SELECT route.route_name FROM(route)"
            Case 2
                cmd.CommandText = "SELECT train.train_name FROM(train)"
            Case 3
                cmd.CommandText = "SELECT stations.station_name FROM(stations)"
            Case 4
                cmd.CommandText = "SELECT stations.station_name FROM(stations)"
            Case 5
                cmd.CommandText = "SELECT operating_days.day_name FROM(operating_days)"
            Case 6
                cmd.CommandText = "SELECT slot_id, arrival_time, hours FROM(time_slots)"
                TimeSet = True
            Case 7
                cmd.CommandText = "SELECT slot_id, departure_time, hours FROM(time_slots)"
                TimeSet = True
            Case Else

        End Select

        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        ComboBox11.ResetText()
        ComboBox11.Items.Clear()

        While cmdreader.Read
            If TimeSet = True Then
                Dim time_set = cmdreader.GetString(1)
                Dim hhr_set = cmdreader.GetString(2)

                Dim option_list = time_set + " " + hhr_set
                ComboBox11.Items.Add(option_list)

            Else
                Dim option_list = cmdreader.GetString(0)
                ComboBox11.Items.Add(option_list)
            End If



        End While

        cmdreader.Close()

        con.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim Value_ini As String = ComboBox11.Text
        Dim Value_final As String

        Try

            Dim rd As MySqlDataReader
            Dim cmd As New MySqlCommand

            '========================================================================================================

            opencon()

            Select Case ComboBox12.SelectedIndex

                Case 0
                    cmd.CommandText = "SELECT `ID` FROM `trip` WHERE trip.ID ='" & Value_ini & "'"
                Case 1
                    cmd.CommandText = "SELECT `route_id` FROM `route` WHERE route.route_name ='" & Value_ini & "'"
                Case 2
                    cmd.CommandText = "SELECT `train_id` FROM `train` WHERE train.train_name ='" & Value_ini & "'"
                Case 3
                    cmd.CommandText = "SELECT `station_id` FROM `stations` WHERE stations.station_name ='" & Value_ini & "'"
                Case 4
                    cmd.CommandText = "SELECT `station_id` FROM `stations` WHERE stations.station_name ='" & Value_ini & "'"
                Case 5
                    cmd.CommandText = "SELECT `day_id` FROM `operating_days` WHERE operating_days.day_name ='" & Value_ini & "'"
                Case 6
                    cmd.CommandText = "SELECT `slot_id` FROM `time_slots` WHERE time_slots.slot_id ='" & id_time_set & "'"
                Case 7
                    cmd.CommandText = "SELECT `slot_id` FROM `time_slots` WHERE time_slots.slot_id ='" & id_time_set & "'"

                Case Else

            End Select

            cmd.Connection = con

            rd = cmd.ExecuteReader

            If rd.Read Then

                Value_final = rd.GetValue(0)

            End If

            rd.Close()
            con.Close()

            '========================================================================================================

            Select Case ComboBox12.SelectedIndex

                Case 0
                    tableload("SELECT ID, route.route_name AS ROUTE, train.train_name AS TRAIN, operating_days.day_name AS DAY, src.station_name AS ORIGIN, des.station_name AS DESTINATION, hrs.hours AS HOURS, arr.arrival_time AS ARRIVES, dpt.departure_time AS DEPARTS FROM trip INNER JOIN route ON trip.ROUTE = route.route_id INNER JOIN train ON trip.TRAIN = train.train_id INNER JOIN operating_days ON trip.DAY = operating_days.day_id INNER JOIN time_slots AS hrs ON trip.ARRIVAL = hrs.slot_id INNER JOIN time_slots AS arr ON trip.ARRIVAL = arr.slot_id INNER JOIN time_slots AS dpt ON trip.DEPARTURE = dpt.slot_id INNER JOIN stations AS src ON trip.ORIGIN = src.station_id INNER JOIN stations AS des ON trip.DESTINATION = des.station_id WHERE trip.ID = '" & Value_final & "' ORDER BY ID", DataGridView1)
                Case 1
                    tableload("SELECT ID, route.route_name AS ROUTE, train.train_name AS TRAIN, operating_days.day_name AS DAY, src.station_name AS ORIGIN, des.station_name AS DESTINATION, hrs.hours AS HOURS, arr.arrival_time AS ARRIVES, dpt.departure_time AS DEPARTS FROM trip INNER JOIN route ON trip.ROUTE = route.route_id INNER JOIN train ON trip.TRAIN = train.train_id INNER JOIN operating_days ON trip.DAY = operating_days.day_id INNER JOIN time_slots AS hrs ON trip.ARRIVAL = hrs.slot_id INNER JOIN time_slots AS arr ON trip.ARRIVAL = arr.slot_id INNER JOIN time_slots AS dpt ON trip.DEPARTURE = dpt.slot_id INNER JOIN stations AS src ON trip.ORIGIN = src.station_id INNER JOIN stations AS des ON trip.DESTINATION = des.station_id WHERE trip.ROUTE = '" & Value_final & "' ORDER BY ID", DataGridView1)
                Case 2
                    tableload("SELECT ID, route.route_name AS ROUTE, train.train_name AS TRAIN, operating_days.day_name AS DAY, src.station_name AS ORIGIN, des.station_name AS DESTINATION, hrs.hours AS HOURS, arr.arrival_time AS ARRIVES, dpt.departure_time AS DEPARTS FROM trip INNER JOIN route ON trip.ROUTE = route.route_id INNER JOIN train ON trip.TRAIN = train.train_id INNER JOIN operating_days ON trip.DAY = operating_days.day_id INNER JOIN time_slots AS hrs ON trip.ARRIVAL = hrs.slot_id INNER JOIN time_slots AS arr ON trip.ARRIVAL = arr.slot_id INNER JOIN time_slots AS dpt ON trip.DEPARTURE = dpt.slot_id INNER JOIN stations AS src ON trip.ORIGIN = src.station_id INNER JOIN stations AS des ON trip.DESTINATION = des.station_id WHERE trip.TRAIN = '" & Value_final & "' ORDER BY ID", DataGridView1)
                Case 3
                    tableload("SELECT ID, route.route_name AS ROUTE, train.train_name AS TRAIN, operating_days.day_name AS DAY, src.station_name AS ORIGIN, des.station_name AS DESTINATION, hrs.hours AS HOURS, arr.arrival_time AS ARRIVES, dpt.departure_time AS DEPARTS FROM trip INNER JOIN route ON trip.ROUTE = route.route_id INNER JOIN train ON trip.TRAIN = train.train_id INNER JOIN operating_days ON trip.DAY = operating_days.day_id INNER JOIN time_slots AS hrs ON trip.ARRIVAL = hrs.slot_id INNER JOIN time_slots AS arr ON trip.ARRIVAL = arr.slot_id INNER JOIN time_slots AS dpt ON trip.DEPARTURE = dpt.slot_id INNER JOIN stations AS src ON trip.ORIGIN = src.station_id INNER JOIN stations AS des ON trip.DESTINATION = des.station_id WHERE trip.ORIGIN = '" & Value_final & "' ORDER BY ID", DataGridView1)
                Case 4
                    tableload("SELECT ID, route.route_name AS ROUTE, train.train_name AS TRAIN, operating_days.day_name AS DAY, src.station_name AS ORIGIN, des.station_name AS DESTINATION, hrs.hours AS HOURS, arr.arrival_time AS ARRIVES, dpt.departure_time AS DEPARTS FROM trip INNER JOIN route ON trip.ROUTE = route.route_id INNER JOIN train ON trip.TRAIN = train.train_id INNER JOIN operating_days ON trip.DAY = operating_days.day_id INNER JOIN time_slots AS hrs ON trip.ARRIVAL = hrs.slot_id INNER JOIN time_slots AS arr ON trip.ARRIVAL = arr.slot_id INNER JOIN time_slots AS dpt ON trip.DEPARTURE = dpt.slot_id INNER JOIN stations AS src ON trip.ORIGIN = src.station_id INNER JOIN stations AS des ON trip.DESTINATION = des.station_id WHERE trip.DESTINATION = '" & Value_final & "' ORDER BY ID", DataGridView1)
                Case 5
                    tableload("SELECT ID, route.route_name AS ROUTE, train.train_name AS TRAIN, operating_days.day_name AS DAY, src.station_name AS ORIGIN, des.station_name AS DESTINATION, hrs.hours AS HOURS, arr.arrival_time AS ARRIVES, dpt.departure_time AS DEPARTS FROM trip INNER JOIN route ON trip.ROUTE = route.route_id INNER JOIN train ON trip.TRAIN = train.train_id INNER JOIN operating_days ON trip.DAY = operating_days.day_id INNER JOIN time_slots AS hrs ON trip.ARRIVAL = hrs.slot_id INNER JOIN time_slots AS arr ON trip.ARRIVAL = arr.slot_id INNER JOIN time_slots AS dpt ON trip.DEPARTURE = dpt.slot_id INNER JOIN stations AS src ON trip.ORIGIN = src.station_id INNER JOIN stations AS des ON trip.DESTINATION = des.station_id WHERE trip.DAY = '" & Value_final & "' ORDER BY ID", DataGridView1)
                Case 6
                    tableload("SELECT ID, route.route_name AS ROUTE, train.train_name AS TRAIN, operating_days.day_name AS DAY, src.station_name AS ORIGIN, des.station_name AS DESTINATION, hrs.hours AS HOURS, arr.arrival_time AS ARRIVES, dpt.departure_time AS DEPARTS FROM trip INNER JOIN route ON trip.ROUTE = route.route_id INNER JOIN train ON trip.TRAIN = train.train_id INNER JOIN operating_days ON trip.DAY = operating_days.day_id INNER JOIN time_slots AS hrs ON trip.ARRIVAL = hrs.slot_id INNER JOIN time_slots AS arr ON trip.ARRIVAL = arr.slot_id INNER JOIN time_slots AS dpt ON trip.DEPARTURE = dpt.slot_id INNER JOIN stations AS src ON trip.ORIGIN = src.station_id INNER JOIN stations AS des ON trip.DESTINATION = des.station_id WHERE trip.ARRIVAL = '" & Value_final & "' ORDER BY ID", DataGridView1)
                Case 7
                    tableload("SELECT ID, route.route_name AS ROUTE, train.train_name AS TRAIN, operating_days.day_name AS DAY, src.station_name AS ORIGIN, des.station_name AS DESTINATION, hrs.hours AS HOURS, arr.arrival_time AS ARRIVES, dpt.departure_time AS DEPARTS FROM trip INNER JOIN route ON trip.ROUTE = route.route_id INNER JOIN train ON trip.TRAIN = train.train_id INNER JOIN operating_days ON trip.DAY = operating_days.day_id INNER JOIN time_slots AS hrs ON trip.ARRIVAL = hrs.slot_id INNER JOIN time_slots AS arr ON trip.ARRIVAL = arr.slot_id INNER JOIN time_slots AS dpt ON trip.DEPARTURE = dpt.slot_id INNER JOIN stations AS src ON trip.ORIGIN = src.station_id INNER JOIN stations AS des ON trip.DESTINATION = des.station_id WHERE trip.DEPARTURE = '" & Value_final & "' ORDER BY ID", DataGridView1)
                Case Else

            End Select

            strconn.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ComboBox11.Items.Clear()

        ComboBox11.ResetText()
        ComboBox12.ResetText()

        If TabControl1.SelectedIndex = 0 Then
            tableload("SELECT ID, route.route_name AS ROUTE, train.train_name AS TRAIN, operating_days.day_name AS DAY, src.station_name AS ORIGIN, des.station_name AS DESTINATION, hrs.hours AS HOURS, arr.arrival_time AS ARRIVES, dpt.departure_time AS DEPARTS FROM trip INNER JOIN route ON trip.ROUTE = route.route_id INNER JOIN train ON trip.TRAIN = train.train_id INNER JOIN operating_days ON trip.DAY = operating_days.day_id INNER JOIN time_slots AS hrs ON trip.ARRIVAL = hrs.slot_id INNER JOIN time_slots AS arr ON trip.ARRIVAL = arr.slot_id INNER JOIN time_slots AS dpt ON trip.DEPARTURE = dpt.slot_id INNER JOIN stations AS src ON trip.ORIGIN = src.station_id INNER JOIN stations AS des ON trip.DESTINATION = des.station_id ORDER BY ID", DataGridView1)
            strconn.Close()

        ElseIf TabControl1.SelectedIndex = 1 Then
            tableload("SELECT route.route_id AS ID, route.route_name AS NAME, src.station_name AS ORIGIN, des.station_name AS END FROM(route) INNER JOIN stations AS src ON route.starts_at_station  = src.station_id INNER JOIN stations AS des ON route.ends_at_station  = des.station_id ORDER BY ID", DataGridView1)
            strconn.Close()

        ElseIf TabControl1.SelectedIndex = 2 Then
            tableload("SELECT train.train_id AS ID, train.train_name AS NAME, route.route_name AS ROUTE FROM(train) INNER JOIN route ON train.assigned_to = route.route_id ORDER BY ID", DataGridView1)
            strconn.Close()

        End If

    End Sub


    Private Sub ComboBox11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox11.SelectedIndexChanged

        If ComboBox12.SelectedIndex = 6 Then

            Select Case ComboBox11.SelectedIndex

                Case 0
                    id_time_set = 1
                Case 1
                    id_time_set = 2
                Case 2
                    id_time_set = 3
                Case 3
                    id_time_set = 4
                Case 4
                    id_time_set = 5
                Case 5
                    id_time_set = 6
                Case 6
                    id_time_set = 7
                Case 7
                    id_time_set = 8
                Case 8
                    id_time_set = 9
                Case 9
                    id_time_set = 10
                Case 10
                    id_time_set = 11
                Case 11
                    id_time_set = 12
                Case 12
                    id_time_set = 13
                Case 13
                    id_time_set = 14
                Case 14
                    id_time_set = 15
                Case 15
                    id_time_set = 16

                Case Else
            End Select

        End If

    End Sub

    '================ROUTES========================================================================================================



    Private Sub btn_get_route_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_get_route.Click


        Dim rd As MySqlDataReader
        Dim cmd As New MySqlCommand

        '========================================================================================================

        opencon()

        cmd.CommandText = "SELECT route_name FROM `route` WHERE route.route_id ='" & tbx_route_id.Text & "'"
        cmd.Connection = con

        rd = cmd.ExecuteReader

        If rd.Read Then

            tbx_route_name.Text = rd.GetValue(0)

        End If

        rd.Close()
        con.Close()

        opencon()

        Dim route_s_ini As Integer
        Dim route_e_ini As Integer

        cmd.CommandText = "SELECT `starts_at_station`, `ends_at_station` FROM `route` WHERE route.route_id ='" & tbx_route_id.Text & "'"
        cmd.Connection = con

        rd = cmd.ExecuteReader

        If rd.Read Then

            route_s_ini = rd.GetValue(0)
            route_e_ini = rd.GetValue(1)

        End If

        rd.Close()
        con.Close()

        opencon()

        cmd.CommandText = "SELECT `station_name` FROM `stations` WHERE stations.station_id = '" & route_s_ini & "'"
        cmd.Connection = con

        rd = cmd.ExecuteReader

        If rd.Read Then

            tbx_route_start.Text = rd.GetValue(0)

        End If

        rd.Close()
        con.Close()

        opencon()

        cmd.CommandText = "SELECT `station_name` FROM `stations` WHERE stations.station_id = '" & route_e_ini & "'"
        cmd.Connection = con

        rd = cmd.ExecuteReader

        If rd.Read Then

            tbx_route_end.Text = rd.GetValue(0)

        End If

        rd.Close()
        con.Close()

            tbx_route_start.Items.Clear()
            tbx_route_end.Items.Clear()

            opencon()

            cmd.Connection = con

        If tbx_route_id.Text > 4 Then
            cmd.CommandText = "SELECT stations.station_name FROM(stations)"
        Else
            cmd.CommandText = "SELECT stations.station_name FROM route_stations INNER JOIN stations ON stations.station_id = route_stations.part_station_id WHERE route_stations.part_of_route_id = '" & tbx_route_id.Text & "'"
        End If

            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                Dim station_options = cmdreader.GetString("station_name")
                tbx_route_start.Items.Add(station_options)
                tbx_route_end.Items.Add(station_options)
                tbx_route_start.Items.Remove(tbx_route_start.Text)
                tbx_route_end.Items.Remove(tbx_route_end.Text)
            End While

            cmdreader.Close()

            con.Close()

            stop_btn_1.Visible = False
            stop_btn_1.BackColor = Color.White
            stop_btn_2.Visible = False
            stop_btn_2.BackColor = Color.White
            stop_btn_3.Visible = False
            stop_btn_3.BackColor = Color.White
            stop_btn_4.Visible = False
            stop_btn_4.BackColor = Color.White
            stop_btn_5.Visible = False
            stop_btn_5.BackColor = Color.White
            stop_btn_6.Visible = False
            stop_btn_6.BackColor = Color.White
            stop_btn_7.Visible = False
            stop_btn_7.BackColor = Color.White

            stop_btn_8.Visible = False
            stop_btn_8.BackColor = Color.White
            stop_btn_9.Visible = False
            stop_btn_9.BackColor = Color.White
            stop_btn_10.Visible = False
            stop_btn_10.BackColor = Color.White
            stop_btn_11.Visible = False
            stop_btn_11.BackColor = Color.White
            stop_btn_12.Visible = False
            stop_btn_12.BackColor = Color.White

            stop_btn_13.Visible = False
            stop_btn_13.BackColor = Color.White
            stop_btn_14.Visible = False
            stop_btn_14.BackColor = Color.White

            Select Case tbx_route_start.Text

                Case "Central Station"
                    stop_btn_1.Visible = True
                    stop_btn_1.BackColor = Color.Green
                Case "Cornelia Station"
                    stop_btn_2.Visible = True
                    stop_btn_2.BackColor = Color.Green
                Case "Valle Aurelia"
                    stop_btn_3.Visible = True
                    stop_btn_3.BackColor = Color.Green
                Case "Lepanto Station"
                    stop_btn_4.Visible = True
                    stop_btn_4.BackColor = Color.Green
                Case "Vittorio Station"
                    stop_btn_5.Visible = True
                    stop_btn_5.BackColor = Color.Green
                Case "Agricola Station"
                    stop_btn_6.Visible = True
                    stop_btn_6.BackColor = Color.Green
                Case "Travertino Station"
                    stop_btn_7.Visible = True
                    stop_btn_7.BackColor = Color.Green
                Case "Quintilianni Station"
                    stop_btn_8.Visible = True
                    stop_btn_8.BackColor = Color.Green
                Case "Magliana Station"
                    stop_btn_9.Visible = True
                    stop_btn_9.BackColor = Color.Green
                Case "Pretorio Station"
                    stop_btn_10.Visible = True
                    stop_btn_10.BackColor = Color.Green
                Case "Massimo Station"
                    stop_btn_11.Visible = True
                    stop_btn_11.BackColor = Color.Green
                Case "Laurentina Station"
                    stop_btn_12.Visible = True
                    stop_btn_12.BackColor = Color.Green
                Case "Manzoni Station"
                    stop_btn_13.Visible = True
                    stop_btn_13.BackColor = Color.Green
                Case "Airport Station"
                    stop_btn_14.Visible = True
                    stop_btn_14.BackColor = Color.Green
                Case Else

            End Select

            Select Case tbx_route_end.Text

                Case "Central Station"
                    stop_btn_1.Visible = True
                    stop_btn_1.BackColor = Color.DarkRed
                Case "Cornelia Station"
                    stop_btn_2.Visible = True
                    stop_btn_2.BackColor = Color.DarkRed
                Case "Valle Aurelia"
                    stop_btn_3.Visible = True
                    stop_btn_3.BackColor = Color.DarkRed
                Case "Lepanto Station"
                    stop_btn_4.Visible = True
                    stop_btn_4.BackColor = Color.DarkRed
                Case "Vittorio Station"
                    stop_btn_5.Visible = True
                    stop_btn_5.BackColor = Color.DarkRed
                Case "Agricola Station"
                    stop_btn_6.Visible = True
                    stop_btn_6.BackColor = Color.DarkRed
                Case "Travertino Station"
                    stop_btn_7.Visible = True
                    stop_btn_7.BackColor = Color.DarkRed
                Case "Quintilianni Station"
                    stop_btn_8.Visible = True
                    stop_btn_8.BackColor = Color.DarkRed
                Case "Magliana Station"
                    stop_btn_9.Visible = True
                    stop_btn_9.BackColor = Color.DarkRed
                Case "Pretorio Station"
                    stop_btn_10.Visible = True
                    stop_btn_10.BackColor = Color.DarkRed
                Case "Massimo Station"
                    stop_btn_11.Visible = True
                    stop_btn_11.BackColor = Color.DarkRed
                Case "Laurentina Station"
                    stop_btn_12.Visible = True
                    stop_btn_12.BackColor = Color.DarkRed
                Case "Manzoni Station"
                    stop_btn_13.Visible = True
                    stop_btn_13.BackColor = Color.DarkRed
                Case "Airport Station"
                    stop_btn_14.Visible = True
                    stop_btn_14.BackColor = Color.DarkRed
                Case Else


            End Select

            opencon()

            active_trains.Items.Clear()

            cmd.Connection = con
            cmd.CommandText = "SELECT train.train_name FROM train WHERE train.assigned_to = '" & tbx_route_id.Text & "'"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                Dim train_options = cmdreader.GetString("train_name")
                active_trains.Items.Add(train_options)
            End While

            cmdreader.Close()

            con.Close()

            bounds.Items.Clear()

            bounds.Items.Add(tbx_route_start.Text)
            bounds.Items.Add(tbx_route_end.Text)

    End Sub


    Private Sub tbx_route_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_route_name.SelectedIndexChanged

        stop_btn_1.Visible = False
        stop_btn_1.BackColor = Color.White
        stop_btn_2.Visible = False
        stop_btn_2.BackColor = Color.White
        stop_btn_3.Visible = False
        stop_btn_3.BackColor = Color.White
        stop_btn_4.Visible = False
        stop_btn_4.BackColor = Color.White
        stop_btn_5.Visible = False
        stop_btn_5.BackColor = Color.White
        stop_btn_6.Visible = False
        stop_btn_6.BackColor = Color.White
        stop_btn_7.Visible = False
        stop_btn_7.BackColor = Color.White

        stop_btn_8.Visible = False
        stop_btn_8.BackColor = Color.White
        stop_btn_9.Visible = False
        stop_btn_9.BackColor = Color.White
        stop_btn_10.Visible = False
        stop_btn_10.BackColor = Color.White
        stop_btn_11.Visible = False
        stop_btn_11.BackColor = Color.White
        stop_btn_12.Visible = False
        stop_btn_12.BackColor = Color.White

        stop_btn_13.Visible = False
        stop_btn_13.BackColor = Color.White
        stop_btn_14.Visible = False
        stop_btn_14.BackColor = Color.White

        Dim rd As MySqlDataReader
        Dim cmd As New MySqlCommand

        Dim route_id_ini As String = tbx_route_name.Text

        Try


            opencon()

            cmd.CommandText = "SELECT `route_id` FROM `route` WHERE route.route_name ='" & route_id_ini & "'"
            cmd.Connection = con

            rd = cmd.ExecuteReader

            If rd.Read Then

                select_route = rd.GetValue(0)
                tbx_route_id.Text = select_route

            End If

            rd.Close()
            con.Close()

        Catch ex As Exception

        End Try

        con.Close()



        active_trains.Items.Clear()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT train.train_name FROM(train) WHERE train.assigned_to = '" & select_route & "'"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim train_option = cmdreader.GetString("train_name")
            active_trains.Items.Add(train_option)
        End While

        cmdreader.Close()

        con.Close()



        'Setting Origin and Destination Options

        tbx_route_start.ResetText()
        tbx_route_end.ResetText()
        tbx_route_start.Items.Clear()
        tbx_route_end.Items.Clear()

        opencon()

        cmd.CommandText = "SELECT sas.station_name AS sas , eas.station_name AS eas FROM `route` INNER JOIN stations AS sas ON sas.station_id = route.starts_at_station INNER JOIN stations AS eas ON eas.station_id = route.ends_at_station WHERE route.route_id ='" & select_route & "'"
        cmd.Connection = con

        rd = cmd.ExecuteReader

        While rd.Read

            tbx_route_start.Text = rd.GetString(0)
            tbx_route_end.Text = rd.GetString(1)

        End While

        rd.Close()
        con.Close()

        opencon()

        cmd.Connection = con


        If tbx_route_name.SelectedIndex > 3 Then
            cmd.CommandText = "SELECT stations.station_name FROM(stations)"
        Else
            cmd.CommandText = "SELECT stations.station_name FROM route_stations INNER JOIN stations ON stations.station_id = route_stations.part_station_id WHERE route_stations.part_of_route_id = '" & select_route & "'"
        End If



        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim station_options = cmdreader.GetString("station_name")
            tbx_route_start.Items.Add(station_options)
            tbx_route_end.Items.Add(station_options)
        End While

        cmdreader.Close()

        con.Close()

        bounds.Items.Clear()

        bounds.Items.Add(tbx_route_start.Text)
        bounds.Items.Add(tbx_route_end.Text)

    End Sub

    Private Sub tbx_route_start_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_route_start.SelectedIndexChanged

        opencon()

        tbx_route_end.Items.Clear()

        cmd.Connection = con
        If tbx_route_id.Text = "1" Then
            cmd.CommandText = "SELECT stations.station_name FROM(stations)"
        ElseIf tbx_route_id.Text = "2" Then
            cmd.CommandText = "SELECT stations.station_name FROM(stations)"
        ElseIf tbx_route_id.Text = "3" Then
            cmd.CommandText = "SELECT stations.station_name FROM(stations)"
        ElseIf tbx_route_id.Text = "" Then
            cmd.CommandText = "SELECT stations.station_name FROM(stations)"
        Else
            cmd.CommandText = "SELECT stations.station_name FROM route_stations INNER JOIN stations ON stations.station_id = route_stations.part_station_id WHERE route_stations.part_of_route_id = '" & tbx_route_id.Text & "'"

        End If
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim station_options = cmdreader.GetString("station_name")
            tbx_route_end.Items.Add(station_options)
        End While

        cmdreader.Close()

        con.Close()

        Dim from = tbx_route_start.Text
        tbx_route_end.Items.Remove(from)

        stop_btn_1.Visible = False
        stop_btn_1.BackColor = Color.White
        stop_btn_2.Visible = False
        stop_btn_2.BackColor = Color.White
        stop_btn_3.Visible = False
        stop_btn_3.BackColor = Color.White
        stop_btn_4.Visible = False
        stop_btn_4.BackColor = Color.White
        stop_btn_5.Visible = False
        stop_btn_5.BackColor = Color.White
        stop_btn_6.Visible = False
        stop_btn_6.BackColor = Color.White
        stop_btn_7.Visible = False
        stop_btn_7.BackColor = Color.White

        stop_btn_8.Visible = False
        stop_btn_8.BackColor = Color.White
        stop_btn_9.Visible = False
        stop_btn_9.BackColor = Color.White
        stop_btn_10.Visible = False
        stop_btn_10.BackColor = Color.White
        stop_btn_11.Visible = False
        stop_btn_11.BackColor = Color.White
        stop_btn_12.Visible = False
        stop_btn_12.BackColor = Color.White

        stop_btn_13.Visible = False
        stop_btn_13.BackColor = Color.White
        stop_btn_14.Visible = False
        stop_btn_14.BackColor = Color.White

        Select Case tbx_route_start.Text

            Case "Central Station"
                stop_btn_1.Visible = True
                stop_btn_1.BackColor = Color.Green
            Case "Cornelia Station"
                stop_btn_2.Visible = True
                stop_btn_2.BackColor = Color.Green
            Case "Valle Aurelia"
                stop_btn_3.Visible = True
                stop_btn_3.BackColor = Color.Green
            Case "Lepanto Station"
                stop_btn_4.Visible = True
                stop_btn_4.BackColor = Color.Green
            Case "Vittorio Station"
                stop_btn_5.Visible = True
                stop_btn_5.BackColor = Color.Green
            Case "Agricola Station"
                stop_btn_6.Visible = True
                stop_btn_6.BackColor = Color.Green
            Case "Travertino Station"
                stop_btn_7.Visible = True
                stop_btn_7.BackColor = Color.Green
            Case "Quintilianni Station"
                stop_btn_8.Visible = True
                stop_btn_8.BackColor = Color.Green
            Case "Magliana Station"
                stop_btn_9.Visible = True
                stop_btn_9.BackColor = Color.Green
            Case "Pretorio Station"
                stop_btn_10.Visible = True
                stop_btn_10.BackColor = Color.Green
            Case "Massimo Station"
                stop_btn_11.Visible = True
                stop_btn_11.BackColor = Color.Green
            Case "Laurentina Station"
                stop_btn_12.Visible = True
                stop_btn_12.BackColor = Color.Green
            Case "Manzoni Station"
                stop_btn_13.Visible = True
                stop_btn_13.BackColor = Color.Green
            Case "Airport Station"
                stop_btn_14.Visible = True
                stop_btn_14.BackColor = Color.Green
            Case Else

        End Select

        Select Case tbx_route_end.Text

            Case "Central Station"
                stop_btn_1.Visible = True
                stop_btn_1.BackColor = Color.DarkRed
            Case "Cornelia Station"
                stop_btn_2.Visible = True
                stop_btn_2.BackColor = Color.DarkRed
            Case "Valle Aurelia"
                stop_btn_3.Visible = True
                stop_btn_3.BackColor = Color.DarkRed
            Case "Lepanto Station"
                stop_btn_4.Visible = True
                stop_btn_4.BackColor = Color.DarkRed
            Case "Vittorio Station"
                stop_btn_5.Visible = True
                stop_btn_5.BackColor = Color.DarkRed
            Case "Agricola Station"
                stop_btn_6.Visible = True
                stop_btn_6.BackColor = Color.DarkRed
            Case "Travertino Station"
                stop_btn_7.Visible = True
                stop_btn_7.BackColor = Color.DarkRed
            Case "Quintilianni Station"
                stop_btn_8.Visible = True
                stop_btn_8.BackColor = Color.DarkRed
            Case "Magliana Station"
                stop_btn_9.Visible = True
                stop_btn_9.BackColor = Color.DarkRed
            Case "Pretorio Station"
                stop_btn_10.Visible = True
                stop_btn_10.BackColor = Color.DarkRed
            Case "Massimo Station"
                stop_btn_11.Visible = True
                stop_btn_11.BackColor = Color.DarkRed
            Case "Laurentina Station"
                stop_btn_12.Visible = True
                stop_btn_12.BackColor = Color.DarkRed
            Case "Manzoni Station"
                stop_btn_13.Visible = True
                stop_btn_13.BackColor = Color.DarkRed
            Case "Airport Station"
                stop_btn_14.Visible = True
                stop_btn_14.BackColor = Color.DarkRed
            Case Else


        End Select

        bounds.Items.Clear()

        bounds.Items.Add(tbx_route_start.Text)
        bounds.Items.Add(tbx_route_end.Text)

    End Sub

    Private Sub tbx_route_end_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_route_end.SelectedIndexChanged

        opencon()

        tbx_route_start.Items.Clear()

        cmd.Connection = con
        If tbx_route_id.Text = "1" Then
            cmd.CommandText = "SELECT stations.station_name FROM(stations)"
        ElseIf tbx_route_id.Text = "2" Then
            cmd.CommandText = "SELECT stations.station_name FROM(stations)"
        ElseIf tbx_route_id.Text = "3" Then
            cmd.CommandText = "SELECT stations.station_name FROM(stations)"
        ElseIf tbx_route_id.Text = "" Then
            cmd.CommandText = "SELECT stations.station_name FROM(stations)"
        Else
            cmd.CommandText = "SELECT stations.station_name FROM route_stations INNER JOIN stations ON stations.station_id = route_stations.part_station_id WHERE route_stations.part_of_route_id = '" & tbx_route_id.Text & "'"

        End If
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim station_options = cmdreader.GetString("station_name")
            tbx_route_start.Items.Add(station_options)
        End While

        cmdreader.Close()

        con.Close()

        Dim from = tbx_route_end.Text
        tbx_route_start.Items.Remove(from)

        stop_btn_1.Visible = False
        stop_btn_1.BackColor = Color.White
        stop_btn_2.Visible = False
        stop_btn_2.BackColor = Color.White
        stop_btn_3.Visible = False
        stop_btn_3.BackColor = Color.White
        stop_btn_4.Visible = False
        stop_btn_4.BackColor = Color.White
        stop_btn_5.Visible = False
        stop_btn_5.BackColor = Color.White
        stop_btn_6.Visible = False
        stop_btn_6.BackColor = Color.White
        stop_btn_7.Visible = False
        stop_btn_7.BackColor = Color.White

        stop_btn_8.Visible = False
        stop_btn_8.BackColor = Color.White
        stop_btn_9.Visible = False
        stop_btn_9.BackColor = Color.White
        stop_btn_10.Visible = False
        stop_btn_10.BackColor = Color.White
        stop_btn_11.Visible = False
        stop_btn_11.BackColor = Color.White
        stop_btn_12.Visible = False
        stop_btn_12.BackColor = Color.White

        stop_btn_13.Visible = False
        stop_btn_13.BackColor = Color.White
        stop_btn_14.Visible = False
        stop_btn_14.BackColor = Color.White

        Select Case tbx_route_start.Text

            Case "Central Station"
                stop_btn_1.Visible = True
                stop_btn_1.BackColor = Color.Green
            Case "Cornelia Station"
                stop_btn_2.Visible = True
                stop_btn_2.BackColor = Color.Green
            Case "Valle Aurelia"
                stop_btn_3.Visible = True
                stop_btn_3.BackColor = Color.Green
            Case "Lepanto Station"
                stop_btn_4.Visible = True
                stop_btn_4.BackColor = Color.Green
            Case "Vittorio Station"
                stop_btn_5.Visible = True
                stop_btn_5.BackColor = Color.Green
            Case "Agricola Station"
                stop_btn_6.Visible = True
                stop_btn_6.BackColor = Color.Green
            Case "Travertino Station"
                stop_btn_7.Visible = True
                stop_btn_7.BackColor = Color.Green
            Case "Quintilianni Station"
                stop_btn_8.Visible = True
                stop_btn_8.BackColor = Color.Green
            Case "Magliana Station"
                stop_btn_9.Visible = True
                stop_btn_9.BackColor = Color.Green
            Case "Pretorio Station"
                stop_btn_10.Visible = True
                stop_btn_10.BackColor = Color.Green
            Case "Massimo Station"
                stop_btn_11.Visible = True
                stop_btn_11.BackColor = Color.Green
            Case "Laurentina Station"
                stop_btn_12.Visible = True
                stop_btn_12.BackColor = Color.Green
            Case "Manzoni Station"
                stop_btn_13.Visible = True
                stop_btn_13.BackColor = Color.Green
            Case "Airport Station"
                stop_btn_14.Visible = True
                stop_btn_14.BackColor = Color.Green
            Case Else

        End Select

        Select Case tbx_route_end.Text

            Case "Central Station"
                stop_btn_1.Visible = True
                stop_btn_1.BackColor = Color.DarkRed
            Case "Cornelia Station"
                stop_btn_2.Visible = True
                stop_btn_2.BackColor = Color.DarkRed
            Case "Valle Aurelia"
                stop_btn_3.Visible = True
                stop_btn_3.BackColor = Color.DarkRed
            Case "Lepanto Station"
                stop_btn_4.Visible = True
                stop_btn_4.BackColor = Color.DarkRed
            Case "Vittorio Station"
                stop_btn_5.Visible = True
                stop_btn_5.BackColor = Color.DarkRed
            Case "Agricola Station"
                stop_btn_6.Visible = True
                stop_btn_6.BackColor = Color.DarkRed
            Case "Travertino Station"
                stop_btn_7.Visible = True
                stop_btn_7.BackColor = Color.DarkRed
            Case "Quintilianni Station"
                stop_btn_8.Visible = True
                stop_btn_8.BackColor = Color.DarkRed
            Case "Magliana Station"
                stop_btn_9.Visible = True
                stop_btn_9.BackColor = Color.DarkRed
            Case "Pretorio Station"
                stop_btn_10.Visible = True
                stop_btn_10.BackColor = Color.DarkRed
            Case "Massimo Station"
                stop_btn_11.Visible = True
                stop_btn_11.BackColor = Color.DarkRed
            Case "Laurentina Station"
                stop_btn_12.Visible = True
                stop_btn_12.BackColor = Color.DarkRed
            Case "Manzoni Station"
                stop_btn_13.Visible = True
                stop_btn_13.BackColor = Color.DarkRed
            Case "Airport Station"
                stop_btn_14.Visible = True
                stop_btn_14.BackColor = Color.DarkRed
            Case Else


        End Select


        bounds.Items.Clear()

        bounds.Items.Add(tbx_route_start.Text)
        bounds.Items.Add(tbx_route_end.Text)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles route_update.Click

        con.Close()

            Dim rd As MySqlDataReader
            Dim cmd As New MySqlCommand

        '========================================================================================================

        Dim ori_id_ini As String = tbx_route_start.Text
        Dim ori_id_final As Integer

        opencon()

        cmd.CommandText = "SELECT `station_id` FROM `stations` WHERE stations.station_name ='" & ori_id_ini & "'"
        cmd.Connection = con

        rd = cmd.ExecuteReader

        If rd.Read Then

            ori_id_final = rd.GetValue(0)

        End If

        rd.Close()
        con.Close()

        '========================================================================================================
        '========================================================================================================

        Dim des_id_ini As String = tbx_route_end.Text
        Dim des_id_final As Integer

        opencon()

        cmd.CommandText = "SELECT `station_id` FROM `stations` WHERE stations.station_name ='" & des_id_ini & "'"
        cmd.Connection = con

        rd = cmd.ExecuteReader

        If rd.Read Then

            des_id_final = rd.GetValue(0)

        End If

        rd.Close()
        con.Close()

        '========================================================================================================

        strconnection()

        cmd.Connection = strconn
        strconn.Open()

        cmd.CommandText = "UPDATE `route` SET `route_name`='" & tbx_route_name.Text & "',`starts_at_station`='" & ori_id_final & "',`ends_at_station`='" & des_id_final & "' WHERE route.route_id ='" & tbx_route_id.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Data Updated")
        strconn.Close()

        tableload("SELECT route.route_id AS ID, route.route_name AS NAME, src.station_name AS ORIGIN, des.station_name AS END FROM(route) INNER JOIN stations AS src ON route.starts_at_station  = src.station_id INNER JOIN stations AS des ON route.ends_at_station  = des.station_id ORDER BY ID", DataGridView1)
        strconn.Close()


    End Sub

    Private Sub route_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles route_delete.Click

        Try
            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.CommandText = "DELETE FROM `route` WHERE route.route_id ='" & tbx_route_id.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Deleted")
            strconn.Close()

            tableload("SELECT route.route_id AS ID, route.route_name AS NAME, src.station_name AS ORIGIN, des.station_name AS END FROM(route) INNER JOIN stations AS src ON route.starts_at_station  = src.station_id INNER JOIN stations AS des ON route.ends_at_station  = des.station_id ORDER BY ID", DataGridView1)
            strconn.Close()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub route_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles route_add.Click



        Dim rd As MySqlDataReader
        Dim cmd As New MySqlCommand

        '========================================================================================================

        Dim ori_id_ini As String = tbx_route_start.Text
        Dim ori_id_final As Integer

        opencon()

        cmd.CommandText = "SELECT `station_id` FROM `stations` WHERE stations.station_name ='" & ori_id_ini & "'"
        cmd.Connection = con

        rd = cmd.ExecuteReader

        If rd.Read Then

            ori_id_final = rd.GetValue(0)

        End If

        rd.Close()
        con.Close()

        '========================================================================================================
        '========================================================================================================

        Dim des_id_ini As String = tbx_route_end.Text
        Dim des_id_final As Integer

        opencon()

        cmd.CommandText = "SELECT `station_id` FROM `stations` WHERE stations.station_name ='" & des_id_ini & "'"
        cmd.Connection = con

        rd = cmd.ExecuteReader

        If rd.Read Then

            des_id_final = rd.GetValue(0)

        End If

        rd.Close()
        con.Close()

        '========================================================================================================

        strconnection()

        cmd.Connection = strconn
        strconn.Open()

        cmd.CommandText = "INSERT INTO `route`(`route_id`, `route_name`, `starts_at_station`, `ends_at_station`) VALUES (DEFAULT,'" & tbx_route_name.Text & "','" & ori_id_final & "','" & des_id_final & "')"
        cmd.ExecuteNonQuery()
        MsgBox("ENTRY ADDED")
        strconn.Close()

        tableload("SELECT route.route_id AS ID, route.route_name AS NAME, src.station_name AS ORIGIN, des.station_name AS END FROM(route) INNER JOIN stations AS src ON route.starts_at_station  = src.station_id INNER JOIN stations AS des ON route.ends_at_station  = des.station_id ORDER BY ID", DataGridView1)
        strconn.Close()

        con.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset_routes.Click

        tbx_route_id.ResetText()
        tbx_route_name.ResetText()

        tbx_route_start.ResetText()
        tbx_route_end.ResetText()

        tbx_route_start.Items.Clear()
        tbx_route_end.Items.Clear()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT stations.station_name FROM(stations)"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim stations_option = cmdreader.GetString("station_name")
            tbx_route_start.Items.Add(stations_option)
            tbx_route_end.Items.Add(stations_option)
        End While

        cmdreader.Close()

        con.Close()


    End Sub

    '+++++++++++++++++++++++++++++++TRAINS+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles get_set_trains.Click

        Dim rd As MySqlDataReader
        Dim cmd As New MySqlCommand
        Dim day_count As Integer
        '========================================================================================================

        opencon()

        cmd.CommandText = "SELECT train_id, train_name, route.route_name FROM `train` INNER JOIN route ON route.route_id = train.assigned_to WHERE train.train_id ='" & tbx_train_id.Text & "'"
        cmd.Connection = con

        rd = cmd.ExecuteReader

        If rd.Read Then

            tbx_train_id.Text = rd.GetValue(0)
            tbx_train_name.Text = rd.GetString(1)
            cbx_train_route.Text = rd.GetString(2)

        End If

        rd.Close()
        con.Close()

        cbx_train_route.Items.Clear()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT route.route_name FROM(route)"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim route_option = cmdreader.GetString("route_name")
            cbx_train_route.Items.Add(route_option)
        End While

        cmdreader.Close()
        con.Close()

        cbx_train_route.Items.Remove(cbx_train_route.Text)
        day_list.Items.Clear()


            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT `working_day` FROM `train_days` WHERE `working_train` = '" & tbx_train_id.Text & "'"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
            Dim day_actual As Integer = cmdreader.GetValue(0)
            day_list.Items.Add(day_actual)
            End While

            cmdreader.Close()
            con.Close()


        btn_mon.BackColor = Color.DimGray
        btn_tue.BackColor = Color.DimGray
        btn_wed.BackColor = Color.DimGray
        btn_thu.BackColor = Color.DimGray
        btn_fri.BackColor = Color.DimGray
        btn_sat.BackColor = Color.DimGray
        btn_sun.BackColor = Color.DimGray


        If day_list.Items.Contains(1) = True Then
            btn_mon.BackColor = Color.DarkGreen
        End If

        If day_list.Items.Contains(2) = True Then
            btn_tue.BackColor = Color.DarkGreen
        End If

        If day_list.Items.Contains(3) = True Then
            btn_wed.BackColor = Color.DarkGreen
        End If

        If day_list.Items.Contains(4) = True Then
            btn_thu.BackColor = Color.DarkGreen
        End If

        If day_list.Items.Contains(5) = True Then
            btn_fri.BackColor = Color.DarkGreen
        End If

        If day_list.Items.Contains(6) = True Then
            btn_sat.BackColor = Color.DarkGreen
        End If


        If day_list.Items.Contains(7) = True Then
            btn_sun.BackColor = Color.DarkGreen
        End If




    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update_train.Click

        Dim rd As MySqlDataReader
        Dim cmd As New MySqlCommand

        Dim train_assignment_id As Integer

        opencon()

        cmd.CommandText = "SELECT route_id FROM `route` WHERE route.route_name ='" & cbx_train_route.Text & "'"
        cmd.Connection = con

        rd = cmd.ExecuteReader

        If rd.Read Then

            train_assignment_id = rd.GetValue(0)

        End If

        rd.Close()
        con.Close()



        strconnection()

        cmd.Connection = strconn
        strconn.Open()

        cmd.CommandText = "UPDATE train SET train_name = '" & tbx_train_name.Text & "',`assigned_to`='" & train_assignment_id & "' WHERE train_id ='" & tbx_train_id.Text & "'"
        cmd.ExecuteNonQuery()
        MsgBox("Data Updated")
        strconn.Close()

        tableload("SELECT train.train_id AS ID, train.train_name AS NAME, route.route_name AS ROUTE FROM(train) INNER JOIN route ON train.assigned_to = route.route_id ORDER BY ID", DataGridView1)
        strconn.Close()

    End Sub

    Private Sub delete_train_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_train.Click

        strconnection()

        cmd.Connection = strconn
        strconn.Open()

        cmd.CommandText = "DELETE FROM `train` WHERE train.train_id ='" & tbx_train_id.Text & "'"
        cmd.ExecuteNonQuery()
        MsgBox("Train Entry Deleted")
        strconn.Close()

        tableload("SELECT train.train_id AS ID, train.train_name AS NAME, route.route_name AS ROUTE FROM(train) INNER JOIN route ON train.assigned_to = route.route_id ORDER BY ID", DataGridView1)
        strconn.Close()

    End Sub


    Private Sub add_train_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_train.Click

        Dim rd As MySqlDataReader
        Dim cmd As New MySqlCommand

        Dim train_assignment_id As Integer

        opencon()

        cmd.CommandText = "SELECT route_id FROM `route` WHERE route.route_name ='" & cbx_train_route.Text & "'"
        cmd.Connection = con

        rd = cmd.ExecuteReader

        If rd.Read Then

            train_assignment_id = rd.GetValue(0)

        End If

        rd.Close()
        con.Close()



        strconnection()

        cmd.Connection = strconn
        strconn.Open()

        cmd.CommandText = "INSERT INTO train (`train_id`, `train_name`, `assigned_to`) VALUES ( DEFAULT ,'" & tbx_train_name.Text & "', '" & train_assignment_id & "')"
        cmd.ExecuteNonQuery()
        MsgBox("Train Added")
        strconn.Close()

        tableload("SELECT train.train_id AS ID, train.train_name AS NAME, route.route_name AS ROUTE FROM(train) INNER JOIN route ON train.assigned_to = route.route_id ORDER BY ID", DataGridView1)
        strconn.Close()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT operating_days.day_name FROM(operating_days)"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim day_option = cmdreader.GetString("day_name")
        End While

        cmdreader.Close()

        con.Close()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset_trains.Click

        btn_mon.BackColor = Color.DimGray
        btn_tue.BackColor = Color.DimGray
        btn_wed.BackColor = Color.DimGray
        btn_thu.BackColor = Color.DimGray
        btn_fri.BackColor = Color.DimGray
        btn_sat.BackColor = Color.DimGray
        btn_sun.BackColor = Color.DimGray

        tbx_train_id.ResetText()
        tbx_train_name.ResetText()
        cbx_train_route.ResetText()

        cbx_train_route.Items.Clear()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT route.route_name FROM(route)"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim route_option = cmdreader.GetString("route_name")
            cbx_train_route.Items.Add(route_option)
        End While

        cmdreader.Close()

        con.Close()

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    '+++++++++++++++++++++++++++++++STATION+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    Private Sub get_station_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles get_station.Click

        Dim rd As MySqlDataReader
        Dim cmd As New MySqlCommand

        '========================================================================================================

        part_of_route_list.Items.Clear()

        opencon()

        cmd.CommandText = "SELECT station_name FROM `stations` WHERE stations.station_id ='" & tbx_stations_id.Text & "'"
        cmd.Connection = con

        rd = cmd.ExecuteReader

        If rd.Read Then

            tbx_station_name.Text = rd.GetString(0)

        End If

        rd.Close()
        con.Close()

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT route.route_name FROM(route)"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read
            Dim route_option = cmdreader.GetString("route_name")
        End While

        cmdreader.Close()

        con.Close()

        opencon()

        cmd.CommandText = "SELECT route.route_name FROM route_stations INNER JOIN route ON route.route_id = route_stations.part_of_route_id WHERE route_stations.part_station_id ='" & tbx_stations_id.Text & "'"
        cmd.Connection = con

        rd = cmd.ExecuteReader

        While rd.Read

            Dim part_route_option = rd.GetString(0)
            part_of_route_list.Items.Add(part_route_option)

        End While

        rd.Close()
        con.Close()

    End Sub

    Private Sub btn_update_station_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update_station.Click

        strconnection()

        cmd.Connection = strconn
        strconn.Open()

        cmd.CommandText = "UPDATE `stations` SET `station_name`='" & tbx_station_name.Text & "' WHERE station_id = '" & tbx_stations_id.Text & "'"
        cmd.ExecuteNonQuery()
        MsgBox("Train Added")
        strconn.Close()

        tableload("SELECT stations.station_id AS ID, stations.station_name AS NAME FROM(stations)", DataGridView1)
        strconn.Close()

    End Sub

    Dim day_set_num As Integer
    Dim train_used As Integer

    Private Sub btn_mon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mon.Click

        If btn_mon.BackColor = Color.DimGray Then
            btn_mon.BackColor = Color.DarkGreen

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT train.train_id FROM train  WHERE train.train_name = '" & tbx_train_name.Text & "'"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                train_used = cmdreader.GetValue(0)
            End While

            cmdreader.Close()

            con.Close()


            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.CommandText = "INSERT INTO `train_days`(`train_days_id`, `working_train`, `working_day`) VALUES (DEFAULT,'" & train_used & "', '1')"
            cmd.ExecuteNonQuery()
            MsgBox("Train Assignment Added")
            strconn.Close()

        ElseIf btn_mon.BackColor = Color.DarkGreen Then
            btn_mon.BackColor = Color.DimGray

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT train.train_id FROM train  WHERE train.train_name = '" & tbx_train_name.Text & "'"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                train_used = cmdreader.GetValue(0)
            End While

            cmdreader.Close()

            con.Close()


            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.CommandText = "DELETE FROM `train_days` WHERE working_train = '" & train_used & "' AND working_DAY = '1'"
            cmd.ExecuteNonQuery()
            MsgBox("Train Assignment Removed")
            strconn.Close()

        End If

    End Sub

    Private Sub btn_tue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tue.Click

        If btn_tue.BackColor = Color.DimGray Then
            btn_mon.BackColor = Color.DarkGreen

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT train.train_id FROM train  WHERE train.train_name = '" & tbx_train_name.Text & "'"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                train_used = cmdreader.GetValue(0)
            End While

            cmdreader.Close()

            con.Close()


            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.CommandText = "INSERT INTO `train_days`(`train_days_id`, `working_train`, `working_day`) VALUES (DEFAULT,'" & train_used & "', '2')"
            cmd.ExecuteNonQuery()
            MsgBox("Train Assignment Added")
            strconn.Close()

        ElseIf btn_tue.BackColor = Color.DarkGreen Then
            btn_mon.BackColor = Color.DimGray

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT train.train_id FROM train  WHERE train.train_name = '" & tbx_train_name.Text & "'"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                train_used = cmdreader.GetValue(0)
            End While

            cmdreader.Close()

            con.Close()


            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.CommandText = "DELETE FROM `train_days` WHERE working_train = '" & train_used & "' AND working_DAY = '2'"
            cmd.ExecuteNonQuery()
            MsgBox("Train Assignment Removed")
            strconn.Close()

        End If

    End Sub

    Private Sub btn_wed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_wed.Click

        If btn_wed.BackColor = Color.DimGray Then
            btn_mon.BackColor = Color.DarkGreen

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT train.train_id FROM train  WHERE train.train_name = '" & tbx_train_name.Text & "'"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                train_used = cmdreader.GetValue(0)
            End While

            cmdreader.Close()

            con.Close()


            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.CommandText = "INSERT INTO `train_days`(`train_days_id`, `working_train`, `working_day`) VALUES (DEFAULT,'" & train_used & "', '3')"
            cmd.ExecuteNonQuery()
            MsgBox("Train Assignment Added")
            strconn.Close()

        ElseIf btn_wed.BackColor = Color.DarkGreen Then
            btn_mon.BackColor = Color.DimGray

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT train.train_id FROM train  WHERE train.train_name = '" & tbx_train_name.Text & "'"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                train_used = cmdreader.GetValue(0)
            End While

            cmdreader.Close()

            con.Close()


            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.CommandText = "DELETE FROM `train_days` WHERE working_train = '" & train_used & "' AND working_DAY = '3'"
            cmd.ExecuteNonQuery()
            MsgBox("Train Assignment Removed")
            strconn.Close()

        End If

    End Sub

    Private Sub btn_thu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_thu.Click

        If btn_thu.BackColor = Color.DimGray Then
            btn_mon.BackColor = Color.DarkGreen

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT train.train_id FROM train  WHERE train.train_name = '" & tbx_train_name.Text & "'"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                train_used = cmdreader.GetValue(0)
            End While

            cmdreader.Close()

            con.Close()


            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.CommandText = "INSERT INTO `train_days`(`train_days_id`, `working_train`, `working_day`) VALUES (DEFAULT,'" & train_used & "', '4')"
            cmd.ExecuteNonQuery()
            MsgBox("Train Assignment Added")
            strconn.Close()

        ElseIf btn_thu.BackColor = Color.DarkGreen Then
            btn_mon.BackColor = Color.DimGray

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT train.train_id FROM train  WHERE train.train_name = '" & tbx_train_name.Text & "'"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                train_used = cmdreader.GetValue(0)
            End While

            cmdreader.Close()

            con.Close()


            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.CommandText = "DELETE FROM `train_days` WHERE working_train = '" & train_used & "' AND working_DAY = '4'"
            cmd.ExecuteNonQuery()
            MsgBox("Train Assignment Removed")
            strconn.Close()

        End If

    End Sub

    Private Sub btn_fri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fri.Click

        If btn_fri.BackColor = Color.DimGray Then
            btn_mon.BackColor = Color.DarkGreen

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT train.train_id FROM train  WHERE train.train_name = '" & tbx_train_name.Text & "'"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                train_used = cmdreader.GetValue(0)
            End While

            cmdreader.Close()

            con.Close()


            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.CommandText = "INSERT INTO `train_days`(`train_days_id`, `working_train`, `working_day`) VALUES (DEFAULT,'" & train_used & "', '5')"
            cmd.ExecuteNonQuery()
            MsgBox("Train Assignment Added")
            strconn.Close()

        ElseIf btn_fri.BackColor = Color.DarkGreen Then
            btn_mon.BackColor = Color.DimGray

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT train.train_id FROM train  WHERE train.train_name = '" & tbx_train_name.Text & "'"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                train_used = cmdreader.GetValue(0)
            End While

            cmdreader.Close()

            con.Close()


            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.CommandText = "DELETE FROM `train_days` WHERE working_train = '" & train_used & "' AND working_DAY = '5'"
            cmd.ExecuteNonQuery()
            MsgBox("Train Assignment Removed")
            strconn.Close()

        End If

    End Sub

    Private Sub btn_sat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sat.Click

        If btn_sat.BackColor = Color.DimGray Then
            btn_mon.BackColor = Color.DarkGreen

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT train.train_id FROM train  WHERE train.train_name = '" & tbx_train_name.Text & "'"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                train_used = cmdreader.GetValue(0)
            End While

            cmdreader.Close()

            con.Close()


            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.CommandText = "INSERT INTO `train_days`(`train_days_id`, `working_train`, `working_day`) VALUES (DEFAULT,'" & train_used & "', '6')"
            cmd.ExecuteNonQuery()
            MsgBox("Train Assignment Added")
            strconn.Close()

        ElseIf btn_sat.BackColor = Color.DarkGreen Then
            btn_mon.BackColor = Color.DimGray

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT train.train_id FROM train  WHERE train.train_name = '" & tbx_train_name.Text & "'"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                train_used = cmdreader.GetValue(0)
            End While

            cmdreader.Close()

            con.Close()


            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.CommandText = "DELETE FROM `train_days` WHERE working_train = '" & train_used & "' AND working_DAY = '6'"
            cmd.ExecuteNonQuery()
            MsgBox("Train Assignment Removed")
            strconn.Close()

        End If

    End Sub

    Private Sub btn_sun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sun.Click

        If btn_sun.BackColor = Color.DimGray Then
            btn_mon.BackColor = Color.DarkGreen

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT train.train_id FROM train  WHERE train.train_name = '" & tbx_train_name.Text & "'"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                train_used = cmdreader.GetValue(0)
            End While

            cmdreader.Close()

            con.Close()


            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.CommandText = "INSERT INTO `train_days`(`train_days_id`, `working_train`, `working_day`) VALUES (DEFAULT,'" & train_used & "', '7')"
            cmd.ExecuteNonQuery()
            MsgBox("Train Assignment Added")
            strconn.Close()

        ElseIf btn_sun.BackColor = Color.DarkGreen Then
            btn_mon.BackColor = Color.DimGray

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT train.train_id FROM train  WHERE train.train_name = '" & tbx_train_name.Text & "'"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read
                train_used = cmdreader.GetValue(0)
            End While

            cmdreader.Close()

            con.Close()


            strconnection()

            cmd.Connection = strconn
            strconn.Open()

            cmd.CommandText = "DELETE FROM `train_days` WHERE working_train = '" & train_used & "' AND working_DAY = '7'"
            cmd.ExecuteNonQuery()
            MsgBox("Train Assignment Removed")
            strconn.Close()

        End If

    End Sub

End Class