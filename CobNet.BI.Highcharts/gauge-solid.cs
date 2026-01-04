using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.Highcharts.Gauge
{



    public class Solid
    {
        private int width;
        private int height;
        public string IdDiv { get; set; }

        public List<Meta> metas { get; set; }

        public int Max { get; set; }
        public int Min { get; set; }
        public int Value { get; set; }

        public Solid(string Id, int width, int height)
        {
            this.width = width;
            this.height = height;
            this.IdDiv = Id;

            this.Min = 0;
            this.Max = 100;
            this.Value = 50;
            metas = new List<Meta>();
        }

        public Solid(int width, int height)
        {
            this.width = width;
            this.height = height;

            this.Min = 0;
            this.Max = 100;
            this.Value = 50;
            metas = new List<Meta>();
        }

        /// <summary>
        /// Adiciona nova meta com cor diferente no grafico
        /// </summary>
        /// <param name="CorHex"> exemplo : #55BF3B</param>
        /// <param name="ValorMeta">90</param>
        public void AdicionaMeta(string CorHex, int ValorMeta)
        {
            metas.Add(new Meta(CorHex, ValorMeta));
        }

        public string DataBind()
        {

            StringBuilder SB = new StringBuilder();

            SB.AppendLine("<div id=\"" + IdDiv + "\" style=\"width: " + width.ToString() + "px; height: " + height.ToString() + "px;\" title=\""+this.Max.ToString()+"\"></div>");
            SB.AppendLine("<script type=\"text/javascript\">");
            SB.AppendLine("$(function () {");
            SB.AppendLine("");
            SB.AppendLine("    var gaugeOptions = {");
            SB.AppendLine("");
            SB.AppendLine("        chart: {");
            SB.AppendLine("            type: 'solidgauge'");
            SB.AppendLine("        },");
            SB.AppendLine("");
            SB.AppendLine("        title: '" + IdDiv + "',");
            SB.AppendLine("");
            SB.AppendLine("        pane: {");
            SB.AppendLine("            center: ['50%', '100%'],");
            SB.AppendLine("            size: '190%',");
            SB.AppendLine("            startAngle: -90,");
            SB.AppendLine("            endAngle: 90,");
            SB.AppendLine("            background: {");
            SB.AppendLine("                backgroundColor: (Highcharts.theme && Highcharts.theme.background2) || '#EEE',");
            SB.AppendLine("                innerRadius: '100%',");
            SB.AppendLine("                outerRadius: '60%',");
            SB.AppendLine("                shape: 'arc'");
            SB.AppendLine("            }");
            SB.AppendLine("        },");
            SB.AppendLine("");
            SB.AppendLine("        tooltip: {");
            SB.AppendLine("            enabled: false");
            SB.AppendLine("        },");
            SB.AppendLine("");
            SB.AppendLine("        // the value axis");
            SB.AppendLine("        yAxis: {");
            SB.AppendLine("            stops: [");


            List<Meta> metasOrder = metas.OrderBy(c => c.Valor).ToList();
            for (int i = 0; i < metas.Count; i++)
            {
                Meta meta = metasOrder[i];

                SB.AppendLine("                [0." + meta.Valor.ToString() + ", '" + meta.CorHex + "']");

                if (i < metas.Count() - 1)
                    SB.AppendLine(",");
            }
            SB.AppendLine("");
            SB.AppendLine("            ],");
            SB.AppendLine("            lineWidth: 0,");
            SB.AppendLine("            minorTickInterval: null,");
            SB.AppendLine("            tickPixelInterval: null,");
            SB.AppendLine("            tickWidth: 0,");
            SB.AppendLine("            title: {");
            SB.AppendLine("                y: -70");
            SB.AppendLine("            },");
            SB.AppendLine("            labels: {");
            SB.AppendLine("                y: 25");
            SB.AppendLine("            }");
            SB.AppendLine("        },");
            SB.AppendLine("");
            SB.AppendLine("        plotOptions: {");
            SB.AppendLine("            solidgauge: {");
            SB.AppendLine("                dataLabels: {");
            SB.AppendLine("                    y: 0,");
            SB.AppendLine("                    borderWidth: 0,");
            SB.AppendLine("                    useHTML: true");
            SB.AppendLine("                }");
            SB.AppendLine("            }");
            SB.AppendLine("        }");
            SB.AppendLine("    };");
            SB.AppendLine("");
            SB.AppendLine("    // The speed gauge");
            SB.AppendLine("    $('#" + IdDiv + "').highcharts(Highcharts.merge(gaugeOptions, {");
            SB.AppendLine("        yAxis: {");
            SB.AppendLine("            min: " + Min.ToString() + ",");
            SB.AppendLine("            max: " + Max.ToString() + ",");
            SB.AppendLine("            title: {");
            SB.AppendLine("                text: ''");
            SB.AppendLine("            }");
            SB.AppendLine("        },");
            SB.AppendLine("");
            SB.AppendLine("        credits: {");
            SB.AppendLine("            enabled: false");
            SB.AppendLine("        },");
            SB.AppendLine("");
            SB.AppendLine("        series: [{");
            SB.AppendLine("            name: ' " + IdDiv + "',");
            SB.AppendLine("            data: [" + Value.ToString() + "],");
            SB.AppendLine("            dataLabels: {");
            SB.AppendLine("                format: '<div style=\"text-align:center\"><span style=\"font-size:"+Convert.ToInt16(height*0.12D)+"px;color:' +");
            SB.AppendLine("                    ((Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black') + '\">{y}</span><br/>' +");
            SB.AppendLine("                       '<span style=\"font-size:12px;color:silver\"></span></div>'");
            SB.AppendLine("            },");
            SB.AppendLine("            tooltip: {");
            SB.AppendLine("                valueSuffix: ''");
            SB.AppendLine("            }");
            SB.AppendLine("        }]");
            SB.AppendLine("    }));");
            SB.AppendLine("});");
            SB.AppendLine("</script>");

            return SB.ToString();
        }

        public class Meta
        {

            public Meta() { }
            public Meta(string CorHex, int Valor)
            {
                this.CorHex = CorHex;
                this.Valor = Valor;
            }
            public string CorHex { get; set; }
            public int Valor { get; set; }
        }
    }
}
