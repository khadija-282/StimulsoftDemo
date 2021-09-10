<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashboardViewer.aspx.cs" Inherits="SSG.DataService.WebApi.DashboardViewer" %>
<%@ Register TagPrefix="cc1" Namespace="Stimulsoft.Report.Web" Assembly="Stimulsoft.Report.Web, Version=2021.3.7, Culture=neutral, PublicKeyToken=ebe6666cba19647a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <cc1:StiWebViewer ID="StiWebViewer1" runat="server"
                LocalizationDirectory="Localization" AllowAutoUpdateCache="False" CacheMode="None" OnGetReport="StiWebViewer1_OnGetReport"
                FullScreenMode="True" ShowFullScreenButton="False" ShowOpenButton="False" ShowSaveButton="False" ></cc1:StiWebViewer>
        </div>
    </form>
</body>
</html>
