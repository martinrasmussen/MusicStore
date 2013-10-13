<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.master" CodeBehind="Default.aspx.cs" Inherits="Website.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Online Music Store</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
<!-- Carousel
    ================================================== -->
    <div id="myCarousel" class="carousel slide container" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner">
            <!-- Carousel items -->
            <div class="item active">
                <img src="/Images/Justin.jpg" alt="First slide"/>
                <div class="container">
                    <div class="carousel-caption">
                        <h1><strong>The 20/20 Experience</strong></h1>
                        <p>Buy Justing Timberlake's latest album, and you'll get free shipping on your order.</p>
                        <p><a class="btn btn-sm btn-primary" href="#" role="button">Add to cart</a></p>
                    </div>
                </div>
            </div>
            <!-- -->
            <div class="item">
                <img src="/Images/Kanye-Jayz.jpg" alt="Second slide"/>
                <div class="container">
                    <div class="carousel-caption">
                         <h1><strong>Watch the Throne</strong></h1>
                        <p>Planning a trip to Paris? This album is a must!</p>
                        <p><a class="btn btn-sm btn-primary" href="#" role="button">Add to cart</a></p>
                    </div>
                </div>
            </div>
            <!-- -->
            <div class="item">
                <img src="/Images/Drake.jpg" alt="Third slide">
                <div class="container">
                    <div class="carousel-caption">
                         <h1><strong>Nothing Was the Same</strong></h1>
                        <p>Not at all. Ex-Degrassi star dropping a new album.</p>
                        <p><a class="btn btn-sm btn-primary" href="#" role="button" >Add to cart</a></p>
                    </div>
                </div>
            </div>
        </div>
        <!-- Carousel nav buttons -->
        <a class="left carousel-control" href="#myCarousel" data-slide="prev"><span class="glyphicon glyphicon-chevron-left"></span></a>
        <a class="right carousel-control" href="#myCarousel" data-slide="next"><span class="glyphicon glyphicon-chevron-right"></span></a>
    </div><!-- /.carousel -->
    <div class="marketing">
        <!-- Albums -->
        <asp:Panel CssClass="row" runat="server" ID="pnlContent"></asp:Panel>
    </div>
</asp:Content>