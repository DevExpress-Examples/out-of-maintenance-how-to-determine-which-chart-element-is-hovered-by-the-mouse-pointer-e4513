<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128567977/12.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4513)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/DetermineHoveredElements/MainPage.xaml) (VB: [MainPage.xaml](./VB/DetermineHoveredElements/MainPage.xaml))
* [MainPage.xaml.cs](./CS/DetermineHoveredElements/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/DetermineHoveredElements/MainPage.xaml.vb))
<!-- default file list end -->
# How to determine which chart element is hovered by the mouse pointer


<p>This example demonstrates how to calculate the hit information for the chart element over which the mouse pointer is hovering. </p><br />
<p>To accomplish this, handle the <strong>ChartControl.MouseMove</strong> event, obtain the current chart element via the <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfChartsChartControl_CalcHitInfotopic"><u>ChartControl.CalcHitInfo</u></a> method, and if the element is not <strong>null</strong> (<strong>Nothing</strong> in Visual Basic), display its information.</p><br />


<br/>


