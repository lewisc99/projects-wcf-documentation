<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="webFormsForRawWcf._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">ASP.NET</h1>
            <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
            <p><a href="http://www.asp.net" class="btn btn-primary btn-md">Learn more &raquo;</a></p>
        </section>

        <div class="row">
            <section class="row row-lg-6" aria-labelledby="aspnetTitle">
                <asp:TextBox Text="" runat="server" ID="TextBox1" />
                <asp:Button ID="btnCallMyMethod" runat="server" OnClick="btnCallMyMethod_Click" Text="Save" UseSubmitBehavior="false" ValidateRequestMode="Disabled"/>
            </section>
            <section class="row" aria-labelledby="aspnetTitle">
                <asp:Label Text="" ID="lblResult" runat="server" />
            </section>
        </div>
    </main>

</asp:Content>
