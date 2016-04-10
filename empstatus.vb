Public Class empstatus

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StorageDataSet.dealerdataQuery' table. You can move, or remove it, as needed.
        Me.DealerdataQueryTableAdapter.Fill(Me.StorageDataSet.dealerdataQuery)
        'TODO: This line of code loads data into the 'StorageDataSet.totaltrainedQuery' table. You can move, or remove it, as needed.
        Me.TotaltrainedQueryTableAdapter.Fill(Me.StorageDataSet.totaltrainedQuery)
        'TODO: This line of code loads data into the 'StorageDataSet.dealerdata_Query' table. You can move, or remove it, as needed.
        TextBox13.Visible = False
        TextBox14.Visible = False
        TextBox15.Visible = False
        TextBox52.Visible = False
        TextBox53.Visible = False
        TextBox54.Visible = False
        TextBox55.Visible = False
        TextBox56.Visible = False
        TextBox57.Visible = False
        TextBox58.Visible = False
        TextBox59.Visible = False
        TextBox60.Visible = False
        Try
            Me.DealerdataQueryTableAdapter.Fill(Me.StorageDataSet.dealerdataQuery)
        Catch ex As Exception
        End Try
        Dim inc, id, ct, tc, G, S, am, ts, tc1, tf, scm, scc, scco, h, de, oth As Integer
        Dim a As String
        Dim gm, sm, asm, tls, tlc, tlf, scmicra, sccbu, sccorp, hostess, delinc, others As String
        Dim a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20 As Boolean
        gm = TextBox13.Text
        sm = TextBox14.Text
        asm = TextBox15.Text

        tls = TextBox52.Text
        tlc = TextBox53.Text
        tlf = TextBox54.Text
        scmicra = TextBox55.Text
        sccbu = TextBox56.Text
        sccorp = TextBox57.Text
        hostess = TextBox58.Text
        delinc = TextBox59.Text
        others = TextBox60.Text


        id = 0
        inc = 0
        G = 0
        S = 0
        am = 0
        ts = 0
        tc1 = 0
        tf = 0
        scm = 0
        scc = 0
        scco = 0
        h = 0
        de = 0
        oth = 0

        ct = Me.DealerdataQueryTableAdapter.cnt()
        While id < ct
            a = Me.StorageDataSet.dealerdataQuery(inc).Item(3)
            If a = gm Then
                G = G + 1

            ElseIf a = sm Then
                S = S + 1
            ElseIf a = asm Then
                am = am + 1
            ElseIf a = tls Then
                ts = ts + 1
            ElseIf a = tlc Then
                tc1 = tc1 + 1
            ElseIf a = tlf Then
                tf = tf + 1
            ElseIf a = scmicra Then
                scm = scm + 1
            ElseIf a = sccbu Then
                scc = scc + 1
            ElseIf a = sccorp Then
                scco = scco + 1
            ElseIf a = hostess Then
                h = h + 1
            ElseIf a = delinc Then
                de = de + 1
            ElseIf a = others Then
                oth = oth + 1




            End If
            id = id + 1
            inc = inc + 1


        End While
        TextBox4.Text = G
        TextBox5.Text = S
        TextBox6.Text = am
        TextBox25.Text = ts
        TextBox26.Text = tc1
        TextBox27.Text = tf
        TextBox28.Text = scm
        TextBox29.Text = scc
        TextBox30.Text = scco
        TextBox31.Text = h
        TextBox32.Text = de
        TextBox33.Text = oth

        'planned
        TextBox1.Text = 10
        TextBox2.Text = 10
        TextBox3.Text = 10
        TextBox16.Text = 10
        TextBox17.Text = 10
        TextBox18.Text = 10
        TextBox19.Text = 10
        TextBox20.Text = 10
        TextBox21.Text = 10
        TextBox22.Text = 10
        TextBox23.Text = 10
        TextBox24.Text = 10

        'balance

        Dim b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12 As Integer
        b1 = 10 - G
        b2 = 10 - S
        b3 = 10 - am
        b5 = 10 - tc1
        b6 = 10 - tf
        b7 = 10 - scm
        b8 = 10 - scc
        b9 = 10 - scco
        b10 = 10 - h
        b11 = 10 - de
        b12 = 10 - oth

        TextBox10.Text = b1
        TextBox11.Text = b2
        TextBox12.Text = b3
        TextBox43.Text = b4
        TextBox44.Text = b5
        TextBox45.Text = b6
        TextBox46.Text = b7
        TextBox47.Text = b8
        TextBox48.Text = b9
        TextBox49.Text = b10
        TextBox50.Text = b11

        TextBox51.Text = b12


        'trained
        inc = 0
        G = 0
        S = 0
        am = 0
        ts = 0
        tc1 = 0
        tf = 0
        scm = 0
        scc = 0
        scco = 0
        h = 0
        de = 0
        oth = 0

        tc = Me.TotaltrainedQueryTableAdapter.tcount()
        While inc < tc
            a = Me.StorageDataSet.totaltrainedQuery(inc).Item(1)

            a1 = Me.StorageDataSet.totaltrainedQuery(inc).Item(3)
            a2 = Me.StorageDataSet.totaltrainedQuery(inc).Item(4)

            a3 = Me.StorageDataSet.totaltrainedQuery(inc).Item(5)
            a4 = Me.StorageDataSet.totaltrainedQuery(inc).Item(6)
            a5 = Me.StorageDataSet.totaltrainedQuery(inc).Item(7)
            a6 = Me.StorageDataSet.totaltrainedQuery(inc).Item(8)
            a7 = Me.StorageDataSet.totaltrainedQuery(inc).Item(9)
            a8 = Me.StorageDataSet.totaltrainedQuery(inc).Item(10)
            a9 = Me.StorageDataSet.totaltrainedQuery(inc).Item(11)
            a10 = Me.StorageDataSet.totaltrainedQuery(inc).Item(12)
            a11 = Me.StorageDataSet.totaltrainedQuery(inc).Item(13)
            a12 = Me.StorageDataSet.totaltrainedQuery(inc).Item(14)
            a13 = Me.StorageDataSet.totaltrainedQuery(inc).Item(15)
            a14 = Me.StorageDataSet.totaltrainedQuery(inc).Item(16)
            a15 = Me.StorageDataSet.totaltrainedQuery(inc).Item(17)
            a16 = Me.StorageDataSet.totaltrainedQuery(inc).Item(18)
            a17 = Me.StorageDataSet.totaltrainedQuery(inc).Item(19)
            a18 = Me.StorageDataSet.totaltrainedQuery(inc).Item(20)
            a19 = Me.StorageDataSet.totaltrainedQuery(inc).Item(21)
            a20 = Me.StorageDataSet.totaltrainedQuery(inc).Item(22)

            If a = gm And (a1 = True Or a2 = True Or a3 = True Or a4 = True Or a5 = True Or a6 = True Or a7 = True Or a8 = True Or a9 = True Or a10 = True Or a11 = True Or a12 = True Or a13 = True Or a14 = True Or a15 = True Or a16 = True Or a17 = True Or a18 = True Or a19 = True Or a20 = True) Then
                G = G + 1


            ElseIf a = sm And (a1 = True Or a2 = True Or a3 = True Or a4 = True Or a5 = True Or a6 = True Or a7 = True Or a8 = True Or a9 = True Or a10 = True Or a11 = True Or a12 = True Or a13 = True Or a14 = True Or a15 = True Or a16 = True Or a17 = True Or a18 = True Or a19 = True Or a20 = True) Then
                S = S + 1


            ElseIf a = asm And (a1 = True Or a2 = True Or a3 = True Or a4 = True Or a5 = True Or a6 = True Or a7 = True Or a8 = True Or a9 = True Or a10 = True Or a11 = True Or a12 = True Or a13 = True Or a14 = True Or a15 = True Or a16 = True Or a17 = True Or a18 = True Or a19 = True Or a20 = True) Then
                am = am + 1
            ElseIf a = tls And (a1 = True Or a2 = True Or a3 = True Or a4 = True Or a5 = True Or a6 = True Or a7 = True Or a8 = True Or a9 = True Or a10 = True Or a11 = True Or a12 = True Or a13 = True Or a14 = True Or a15 = True Or a16 = True Or a17 = True Or a18 = True Or a19 = True Or a20 = True) Then
                ts = ts + 1
            ElseIf a = tlc And (a1 = True Or a2 = True Or a3 = True Or a4 = True Or a5 = True Or a6 = True Or a7 = True Or a8 = True Or a9 = True Or a10 = True Or a11 = True Or a12 = True Or a13 = True Or a14 = True Or a15 = True Or a16 = True Or a17 = True Or a18 = True Or a19 = True Or a20 = True) Then
                tc1 = tc1 + 1
            ElseIf a = tlf And (a1 = True Or a2 = True Or a3 = True Or a4 = True Or a5 = True Or a6 = True Or a7 = True Or a8 = True Or a9 = True Or a10 = True Or a11 = True Or a12 = True Or a13 = True Or a14 = True Or a15 = True Or a16 = True Or a17 = True Or a18 = True Or a19 = True Or a20 = True) Then
                tf = tf + 1
            ElseIf a = scmicra And (a1 = True Or a2 = True Or a3 = True Or a4 = True Or a5 = True Or a6 = True Or a7 = True Or a8 = True Or a9 = True Or a10 = True Or a11 = True Or a12 = True Or a13 = True Or a14 = True Or a15 = True Or a16 = True Or a17 = True Or a18 = True Or a19 = True Or a20 = True) Then
                scm = scm + 1
            ElseIf a = sccbu And (a1 = True Or a2 = True Or a3 = True Or a4 = True Or a5 = True Or a6 = True Or a7 = True Or a8 = True Or a9 = True Or a10 = True Or a11 = True Or a12 = True Or a13 = True Or a14 = True Or a15 = True Or a16 = True Or a17 = True Or a18 = True Or a19 = True Or a20 = True) Then
                scc = scc + 1
            ElseIf a = sccorp And (a1 = True Or a2 = True Or a3 = True Or a4 = True Or a5 = True Or a6 = True Or a7 = True Or a8 = True Or a9 = True Or a10 = True Or a11 = True Or a12 = True Or a13 = True Or a14 = True Or a15 = True Or a16 = True Or a17 = True Or a18 = True Or a19 = True Or a20 = True) Then
                scco = scco + 1
            ElseIf a = hostess And (a1 = True Or a2 = True Or a3 = True Or a4 = True Or a5 = True Or a6 = True Or a7 = True Or a8 = True Or a9 = True Or a10 = True Or a11 = True Or a12 = True Or a13 = True Or a14 = True Or a15 = True Or a16 = True Or a17 = True Or a18 = True Or a19 = True Or a20 = True) Then
                h = h + 1
            ElseIf a = delinc And (a1 = True Or a2 = True Or a3 = True Or a4 = True Or a5 = True Or a6 = True Or a7 = True Or a8 = True Or a9 = True Or a10 = True Or a11 = True Or a12 = True Or a13 = True Or a14 = True Or a15 = True Or a16 = True Or a17 = True Or a18 = True Or a19 = True Or a20 = True) Then
                de = de + 1
            ElseIf a = others And (a1 = True Or a2 = True Or a3 = True Or a4 = True Or a5 = True Or a6 = True Or a7 = True Or a8 = True Or a9 = True Or a10 = True Or a11 = True Or a12 = True Or a13 = True Or a14 = True Or a15 = True Or a16 = True Or a17 = True Or a18 = True Or a19 = True Or a20 = True) Then
                oth = oth + 1

            End If
            inc = inc + 1

        End While
        TextBox7.Text = G
        TextBox8.Text = S
        TextBox9.Text = am
        TextBox34.Text = ts
        TextBox35.Text = tc1
        TextBox36.Text = tf
        TextBox37.Text = scm
        TextBox38.Text = scc
        TextBox39.Text = scco
        TextBox40.Text = h
        TextBox41.Text = de
        TextBox42.Text = oth







    End Sub

    Private Sub TextBox15_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox15.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class