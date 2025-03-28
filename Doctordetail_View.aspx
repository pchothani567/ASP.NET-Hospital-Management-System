<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DoctorDetail_View.aspx.cs" Inherits="Project_Hospital.Admin.DoctorDetail_View" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content5" runat="server" contentplaceholderid="ContentPlaceHolder1">
              
</asp:Content>

<asp:Content ID="Content6" runat="server" contentplaceholderid="ContentPlaceHolder2">
    
    <br /><br />

    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Photo") %>' />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text='<%# Eval("Gender") %>'></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text='<%# Eval("Speciality") %>'></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text='<%# Eval("Phone") %>'></asp:Label>
        </ItemTemplate>
    </asp:DataList>

    <br /><br />
</asp:Content>


<asp:Content ID="Content7" runat="server" contentplaceholderid="ContentPlaceHolder3">
                 
</asp:Content>

