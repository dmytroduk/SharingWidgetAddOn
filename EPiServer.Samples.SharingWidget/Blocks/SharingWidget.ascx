﻿<%@ Control Language="C#" AutoEventWireup="false" CodeBehind="SharingWidget.ascx.cs" 
    Inherits="EPiServer.Samples.SharingWidget.Blocks.SharingWidget, EPiServer.Samples.SharingWidget" %>

<script type="text/javascript">    var switchTo5x = true;</script>
<script type="text/javascript" src="http://w.sharethis.com/button/buttons.js"></script>
<script type="text/javascript">    stLight.options({ publisher: "<%= CurrentBlock.PublisherId %>" }); </script>

<span class='st_twitter' displayText='Tweet'></span>
<span class='st_facebook' displayText='Facebook'></span>
<span class='st_googleplus' displayText='Google +'></span>
<span class='st_linkedin' displayText='LinkedIn'></span>
<span class='st_sharethis' displayText='ShareThis'></span>

