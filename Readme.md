<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128575717/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T316036)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/QualitativeScaleCustomSortOrderSample/Form1.cs) (VB: [Form1.vb](./VB/QualitativeScaleCustomSortOrderSample/Form1.vb))**
* [NumberComparer.cs](./CS/QualitativeScaleCustomSortOrderSample/NumberComparer.cs) (VB: [NumberComparer.vb](./VB/QualitativeScaleCustomSortOrderSample/NumberComparer.vb))
<!-- default file list end -->
# How to sort qualitative values in a custom order


<p>This example demonstrates how to implement a custom <a href="https://documentation.devexpress.com/CoreLibraries/DevExpress.XtraCharts.AxisBase.QualitativeScaleComparer.property">QualitativeScaleComparer</a> to sort the qualitative scale in a certain order.</p>


<h3>Description</h3>

To do this, assign an object of a class implementing the <strong>System.Collections.IComparer</strong> interface to the <strong>AxisBase.QualitativeScaleComparer</strong> property.

<br/>


