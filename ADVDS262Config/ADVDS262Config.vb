Imports MaterialSkin
Imports System.Management
Imports System.Net.NetworkInformation
Imports System.Text.RegularExpressions

Public Class ADVDS262Config

    Private Sub btnSetComputerName_Click(sender As Object, e As EventArgs)

    End Sub

    Private Declare Function SetComputerName Lib "kernel32" Alias "SetComputerNameA" (ByVal lpComputerName As String) As Long

    Private Sub lblStep1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnChangeDescript_Click(sender As Object, e As EventArgs)

        If Microsoft.Win32.Registry.LocalMachine.OpenSubKey("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\LanmanServer\\Parameters") Is Nothing Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\LanmanServer\Parameters",
                                          "srvcomment", txtChangePCDescription.Text)
        Else
            MsgBox("Bestaat")
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles btnChangePCName.Click
        Dim name As String = "NietCorrect"
        Dim password As String = "Passw0rd!"
        Dim username As String = "IEUser"

        Dim objWMIService = GetObject("Winmgmts:root\cimv2")
        If txtComputerName.Text = "" Then
            MsgBox("Mag niet leeg zijn")
        Else
            name = txtComputerName.Text
        End If
        ' Call always gets only one Win32_ComputerSystem object.
        For Each objComputer In objWMIService.InstancesOf("Win32_ComputerSystem")
            objComputer.rename(name, password)


        Next

        MsgBox("Reboot is necessary for the name to change!")
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialSingleLineTextField1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        If Microsoft.Win32.Registry.LocalMachine.OpenSubKey("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\LanmanServer\\Parameters") Is Nothing Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\LanmanServer\Parameters",
                                          "srvcomment", txtChangePCDescription.Text)
        Else
            MsgBox("Bestaat")
        End If
    End Sub

    Private Sub MaterialFlatButton1_Click_1(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        MsgBox("Reboot in 5 seconds")
        Shell("Shutdown -r -f -t 5")
    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        Dim IPAddress As String = IpAddressControl1.Text 'this is the IP string
        Dim SubnetMask As String = IpAddressControl2.Text 'subnet string
        Dim Gateway As String = IpAddressControl3.Text 'gateway
        Dim dns1 As String = IpAddressControl4.Text 'dns1
        setupNetwork(getMacAddress, IPAddress, SubnetMask, Gateway, dns1, dns1)



    End Sub
    Function getMacAddress()
        Dim nics() As NetworkInterface =
              NetworkInterface.GetAllNetworkInterfaces
        Return nics(0).GetPhysicalAddress.ToString
    End Function

    Function setupNetwork(phyAddr As String, ipAddr As String, netmask As String, gateway As String, dns1 As String, dns2 As String) As Boolean
        Dim result As Boolean = False

        ' concatenate two dns addresses into one
        Dim dnsSearchOrder As String = dns1 + "," + dns2

        Dim objMC As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim objMOC As ManagementObjectCollection = objMC.GetInstances()

        For Each objMO As ManagementObject In objMOC

            If (CBool(objMO("IPEnabled"))) Then

                ' remove colons from mac address so that it could match the
                ' provided mac address
                Dim origMAC As String = objMO("MacAddress").ToString()
                Dim pattern As String = ":"
                Dim replacement As String = ""
                Dim rgx As New Regex(pattern)
                ' the mac address with colons removed from it
                Dim repMAC As String = rgx.Replace(origMAC, replacement)


                Try
                        Dim objNewIP As ManagementBaseObject = Nothing
                        Dim objNewGate As ManagementBaseObject = Nothing
                        Dim objNewDNS As ManagementBaseObject = Nothing
                        Dim objSetIP As ManagementBaseObject = Nothing

                        objNewIP = objMO.GetMethodParameters("EnableStatic")
                        objNewGate = objMO.GetMethodParameters("SetGateways")
                        objNewDNS = objMO.GetMethodParameters("SetDNSServerSearchOrder")

                        'set defaultgateway
                        objNewGate("DefaultIPGateway") = New String() {gateway}
                        objNewGate("GatewayCostMetric") = New Integer() {1}

                        'set ipaddress and subnetmask
                        objNewIP("IPAddress") = New String() {ipAddr}
                        objNewIP("SubnetMask") = New String() {netmask}
                        objNewDNS("DNSServerSearchOrder") = dnsSearchOrder.Split(",")

                        objSetIP = objMO.InvokeMethod("EnableStatic", objNewIP, Nothing)
                        objSetIP = objMO.InvokeMethod("SetGateways", objNewGate, Nothing)
                        objSetIP = objMO.InvokeMethod("SetDNSServerSearchOrder", objNewDNS, Nothing)

                        result = True
                        Exit For

                    Catch ex As Exception
                        MsgBox("Couldn't Set IP Address!")
                        Console.Read()


                    End Try

                End If

          
        Next



        Return result

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Dim sProxy As New IEProxy
        sProxy.SetProxy(TextBox1.Text)
    End Sub
End Class
