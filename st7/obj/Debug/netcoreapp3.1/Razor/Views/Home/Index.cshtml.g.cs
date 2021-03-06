#pragma checksum "C:\Users\mathi\ST7\st7\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64032b7a306cc719bc2a46371336991af671514c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\mathi\ST7\st7\Views\_ViewImports.cshtml"
using st7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mathi\ST7\st7\Views\_ViewImports.cshtml"
using st7.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64032b7a306cc719bc2a46371336991af671514c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c32cacfe86d50505b222840b35a52b4eacf9192e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mathi\ST7\st7\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Home Page";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
	<h1 class=""display-4"">Yo!</h1>
	<p>We can put visual stuff here! </p>
</div>



<center>
	<div class=""chartbox"" id=""firstBox"">
		<canvas id=""chr_example""></canvas>
	</div>
</center>

<div>
	<label for=""numline"">Id for API class</label><br />
	<input type=""number"" id=""numline"" min=""0"" value=""0"" />
	<button type=""button"" class=""btn_example"" id=""api_button""> Get data </button>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
	
	<script>
		document.getElementById('api_button').addEventListener('click', function () {
			//$.ajax({
			//	type: ""<methodType>"",
			//	url: 'api/<method>',
			//	data: {},
			//	contentType: ""application/json; charset=utf-8"",
			//	dataType: ""json"",
			//	success: function (response) {
			//	},
			//	failure: function (e) {
			//	}

			var val = document.getElementById('numline');
			if (val.value <= 0) {
				alert(""Please insert and ID"");
			} else {
				$.ajax({
					type: ""GET"",
					url: 'api/GetClass',
					data: {
						id: val.value
					},
					contentType: ""application/json; charset=utf-8"",
					dataType: ""json"",
					success: function (response) {
						console.log(response);
					},
					failure: function (e) {
						alert(e);
					}
				});
			}


		});


	</script>

	<script>
		Chart.defaults.global.defaultFontColor = 'white';
		var ctx = document.getElementById('chr_example').getContext('2d');
		var exChart = new Chart(ctx, {
			type: 'line',
");
                WriteLiteral(@"			data: {
				labels: ['One', 'Two', 'Three', 'Four', 'Five', 'Six', 'Seven', 'Eight', 'Nine', 'Ten', 'Eleven',
					'Twelve', 'Thirteen', 'Fourteen', 'Sixteen', 'Seventeen'],
				datasets: [{
					label: '# of Votes',
					data: [0, 1, 3, 5, 10, 15, 19, 14, 8, 5, 2, 1, 1, 3, 5, 8, 15],
					backgroundColor: [
						'rgba(255, 140, 0, 0.8)'
					],
					borderColor: [
						'rgba(255, 140, 0, 0.8)'
					],
					borderWidth: 1
				}]
			},
			options: {
				legend: {
					display: false
				},
				scales: {
					yAxes: [{
						ticks: {
							beginAtZero: true
						}
					}]
				}
			}
		});
	</script>

");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
