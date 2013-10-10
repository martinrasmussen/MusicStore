<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.master" CodeBehind="Default.aspx.cs" Inherits="Website.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Home</title>
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
            <div class="item active">
                <img src="/Images/2020-carousel.jpg" data-src="holder.js" alt="First slide"/>
                <div class="container">
                    <div class="carousel-caption">
                        <h1>The 20/20 Experience</h1>
                        <p>Buy Justing Timberlake's latest album, and you'll get free shipping on your order.</p>
                        <p><a class="btn btn-lg btn-primary" href="#" role="button">Add to cart</a></p>
                    </div>
                </div>
            </div>
            <div class="item">
                <img src="data:image/png;base64," data-src="holder.js/900x500/auto/#666:#6a6a6a/text:Second slide" alt="Second slide"/>
                <div class="container">
                    <div class="carousel-caption">
                        <h1>Another example headline.</h1>
                        <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                        <p><a class="btn btn-lg btn-primary" href="#" role="button">Add to cart</a></p>
                    </div>
                </div>
            </div>
            <div class="item">
                <img src="data:image/png;base64," data-src="holder.js/900x500/auto/#555:#5a5a5a/text:Third slide" alt="Third slide">
                <div class="container">
                    <div class="carousel-caption">
                        <h1>One more for good measure.</h1>
                        <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                        <p><a class="btn btn-lg btn-primary" href="#" role="button" >Add to cart</a></p>
                    </div>
                </div>
            </div>
        </div>
        <a class="left carousel-control" href="#myCarousel" data-slide="prev"><span class="glyphicon glyphicon-chevron-left"></span></a>
        <a class="right carousel-control" href="#myCarousel" data-slide="next"><span class="glyphicon glyphicon-chevron-right"></span></a>
    </div><!-- /.carousel -->
    <div class="marketing">
        <asp:Panel runat="server" ID="pnlContent"></asp:Panel>
    </div>
</asp:Content>