<%@ Page Title="Welcome" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AutoWizImportsLimited._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="myCarousel" class="carousel slide" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>
        </ol>

        <!-- Wrapper for slides -->
        <div class="carousel-inner">
            <div class="item active">
                <img src="Images/slide2.jpeg" alt="No Image Found!">
                <div class="carousel-caption">
                    <h3>Servicing Parts</h3>
                    <p>Best prices in servicing parts!</p>
                </div>
            </div>

            <div class="item">
                <img src="Images/slide3.jpeg" alt="No Image Found!">
                <div class="carousel-caption">
                    <h3>Suspension Parts</h3>
                    <p>Drive with comfort!</p>
                </div>
            </div>

            <div class="item">
                <img src="Images/slide4.jpeg" alt="No Image Found!">
                <div class="carousel-caption">
                    <h3>Accessories</h3>
                    <p>Get that custom slick look!</p>
                </div>
            </div>

              <div class="item">
                <img src="Images/slide6.jpeg" alt="No Image Found!">
                <div class="carousel-caption">
                    <h3>Engine Parts</h3>
                    <p>Upgrade your vehicle performance!</p>
                </div>
            </div>
        </div>

        <!-- Left and right controls -->
        <a class="left carousel-control" href="#myCarousel" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#myCarousel" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>
</asp:Content>
