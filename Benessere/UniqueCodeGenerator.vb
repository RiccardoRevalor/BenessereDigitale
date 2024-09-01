Imports System.Net.NetworkInformation
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Public Class UniqueCodeGenerator
    Public Shared Function GetUniqueCode() As String
        Dim macAddress As String = GetMACAddress()
        Dim uniqueCode As String = ""

        If Not String.IsNullOrEmpty(macAddress) Then
            uniqueCode = "$EnhPC" & HashMACAddress(macAddress) + (DateTime.Now.Day + 10).ToString + "£" + (DateTime.Now.Month + 24).ToString + "£" + (DateTime.Now.Year - 1077).ToString
        End If

        Return uniqueCode
    End Function

    Private Shared Function GetMACAddress() As String
        Dim macAddress As String = ""

        Try
            Dim networkInterfaces As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()

            For Each networkInterface As NetworkInterface In networkInterfaces
                If networkInterface.NetworkInterfaceType = NetworkInterfaceType.Ethernet OrElse networkInterface.NetworkInterfaceType = NetworkInterfaceType.Wireless80211 Then
                    macAddress = networkInterface.GetPhysicalAddress().ToString()
                    Exit For
                End If
            Next
        Catch ex As Exception
            ' Gestire l'eccezione o fornire un valore predefinito
        End Try

        Return macAddress
    End Function

    Private Shared Function HashMACAddress(macAddress As String) As String
        Dim sha256 As New SHA256CryptoServiceProvider()
        Dim dataBytes As Byte() = Encoding.UTF8.GetBytes(macAddress)
        Dim hashBytes As Byte() = sha256.ComputeHash(dataBytes)
        Dim hashedMACAddress As String = BitConverter.ToString(hashBytes).Replace("-", "")

        Return hashedMACAddress
    End Function

    Public Shared Sub SetHiddenAttribute(filePath As String)
        ' Imposta l'attributo "nascosto" del file
        File.SetAttributes(filePath, File.GetAttributes(filePath) Or FileAttributes.Hidden)
    End Sub

    Public Shared Sub RemoveHiddenAttribute(filePath As String)
        ' Rimuove l'attributo "nascosto" dal file
        File.SetAttributes(filePath, File.GetAttributes(filePath) And Not FileAttributes.Hidden)
    End Sub
End Class
