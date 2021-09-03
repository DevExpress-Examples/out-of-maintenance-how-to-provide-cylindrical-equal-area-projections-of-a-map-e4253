<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128571808/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4253)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/AvoidMapDistortion/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/AvoidMapDistortion/MainWindow.xaml))
* **[MainWindow.xaml.cs](./CS/AvoidMapDistortion/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/AvoidMapDistortion/MainWindow.xaml.vb))**
<!-- default file list end -->
# How to provide cylindrical equal-area projections of a map


<p>This example demonstrates how to customize the width/height ratio of the map projection. <br />In this example, the following ratios for the <a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfMapEqualAreaProjectiontopic">Equal-area projection</a> are used. The ratio values can be found using the following link: <a href="http://en.wikipedia.org/wiki/Cylindrical_equal-area_projection#Description">Cylindrical Equal-area projection</a>.<br />- Lambert;<br />- Behrmann;<br />- Trystan Edwards;<br />- Gall-Peters;<br />- Balthasart.</p>


<h3>Description</h3>

To specify the ratio, use the&nbsp;<strong>MapControl.InitialMapSize</strong>&nbsp;property.

<br/>


