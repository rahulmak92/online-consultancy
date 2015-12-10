<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageLogin.master" AutoEventWireup="true" CodeFile="Tweets.aspx.cs" Inherits="Tweets" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script>    !function (d, s, id) { var js, fjs = d.getElementsByTagName(s)[0], p = /^http:/.test(d.location) ? 'http' : 'https'; if (!d.getElementById(id)) { js = d.createElement(s); js.id = id; js.src = p + "://platform.twitter.com/widgets.js"; fjs.parentNode.insertBefore(js, fjs); } } (document, "script", "twitter-wjs");</script>
    <script>        !function (d, s, id) { var js, fjs = d.getElementsByTagName(s)[0], p = /^http:/.test(d.location) ? 'http' : 'https'; if (!d.getElementById(id)) { js = d.createElement(s); js.id = id; js.src = p + "://platform.twitter.com/widgets.js"; fjs.parentNode.insertBefore(js, fjs); } } (document, "script", "twitter-wjs");</script>
    <div style="height:30px;font-family:Arial;color:Purple;font-size:20px;font-weight:bold">TWITTER FEED</div>
    <div style="float:left;width:100%">
    <div style="width:50%;float:left">
    <a class="twitter-timeline" href="https://twitter.com/consulhouse2015" data-widget-id="574978701391097856">Tweets by @consulhouse2015</a>
    </div>
    <div style="width:50%;float:left">
    <a class="twitter-timeline" href="https://twitter.com/hashtag/CH2015" data-widget-id="574980266495598592">#CH2015 Tweets</a>
    </div>
    </div>
</asp:Content>

