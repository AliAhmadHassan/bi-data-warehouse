using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.Highcharts.Gauge
{



    public class gauge
    {
        private int width;
        private int height;
        public string IdDiv { get; set; }

        public List<Meta> metas { get; set; }

        public int Max { get; set; }
        public int Min { get; set; }
        public int Value { get; set; }

        public gauge(string Id, int width, int height)
        {
            this.width = width;
            this.height = height;
            this.IdDiv = Id;

            this.Min = 0;
            this.Max = 100;
            this.Value = 50;
            metas = new List<Meta>();
        }

        public gauge(int width, int height)
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
            SB.AppendLine("<div id=\"" + IdDiv + "\" style=\"width: " + width.ToString() + "px; height: " + height.ToString() + "px;\" title=\"" + this.Max.ToString() + "\"></div>");
            SB.AppendLine("<script type=\"text/javascript\">");
            SB.AppendLine("	$(function () {");
            SB.AppendLine("");
            SB.AppendLine("	    $('#" + IdDiv + "').highcharts({");
            SB.AppendLine("");
            SB.AppendLine("chart: {");
            SB.AppendLine("		    type: 'gauge',");
            SB.AppendLine("		    plotBackgroundColor: null,");
            SB.AppendLine("		    plotBackgroundImage: null,");
            SB.AppendLine("		    plotBorderWidth: 0,");
            SB.AppendLine("		    plotShadow: false");
            SB.AppendLine("		},");
            SB.AppendLine("");
            SB.AppendLine("title: {");
            SB.AppendLine("		    text: null");
            SB.AppendLine("		}, credits: {enabled: false},");
            SB.AppendLine("");
            SB.AppendLine("pane: {");
            SB.AppendLine("		    startAngle: -150,");
            SB.AppendLine("		    endAngle: 150,");
            SB.AppendLine("		    background: [{");
            SB.AppendLine("			backgroundColor: {");
            SB.AppendLine("			    linearGradient: { x1: 0, y1: 0, x2: 0, y2: 1 },");
            SB.AppendLine("			    stops: [");
            SB.AppendLine("				[0, '#FFF'],");
            SB.AppendLine("				[1, '#333']");
            SB.AppendLine("			    ]");
            SB.AppendLine("			},");
            SB.AppendLine("			borderWidth: 0,");
            SB.AppendLine("			outerRadius: '109%'");
            SB.AppendLine("		    }, {");
            SB.AppendLine("			backgroundColor: {");
            SB.AppendLine("			    linearGradient: { x1: 0, y1: 0, x2: 0, y2: 1 },");
            SB.AppendLine("			    stops: [");
            SB.AppendLine("				[0, '#333'],");
            SB.AppendLine("				[1, '#FFF']");
            SB.AppendLine("			    ]");
            SB.AppendLine("			},");
            SB.AppendLine("			borderWidth: 1,");
            SB.AppendLine("			outerRadius: '107%'");
            SB.AppendLine("		    }, {");
            SB.AppendLine("			// default background");
            SB.AppendLine("		    }, {");
            SB.AppendLine("			backgroundColor: '#DDD',");
            SB.AppendLine("			borderWidth: 0,");
            SB.AppendLine("			outerRadius: '105%',");
            SB.AppendLine("			innerRadius: '103%'");
            SB.AppendLine("		    }]");
            SB.AppendLine("		},");
            SB.AppendLine("");
            SB.AppendLine("// the value axis");
            SB.AppendLine("		yAxis: {");
            SB.AppendLine("		    min: 0,");
            SB.AppendLine("		    max: "+this.Max+",");
            SB.AppendLine("");
            SB.AppendLine("		    minorTickInterval: 'auto',");
            SB.AppendLine("		    minorTickWidth: 1,");
            SB.AppendLine("		    minorTickLength: 10,");
            SB.AppendLine("		    minorTickPosition: 'inside',");
            SB.AppendLine("		    minorTickColor: '#666',");
            SB.AppendLine("");
            SB.AppendLine("		    tickPixelInterval: 30,");
            SB.AppendLine("		    tickWidth: 2,");
            SB.AppendLine("		    tickPosition: 'inside',");
            SB.AppendLine("		    tickLength: 10,");
            SB.AppendLine("		    tickColor: '#666',");
            SB.AppendLine("		    labels: {");
            SB.AppendLine("			step: 3,");
            SB.AppendLine("			rotation: 'auto'");
            SB.AppendLine("		    },");
            SB.AppendLine("		    title: {");
            SB.AppendLine("			text: null");
            SB.AppendLine("		    },");
            SB.AppendLine("		    plotBands: [");
            
            

            List<Meta> metasOrder = metas.OrderBy(c => c.Valor).ToList();
            for (int i = 1; i < metas.Count; i++)
            {
                SB.AppendLine("                 {from: " + Math.Round((this.Max * (metasOrder[i-1].Valor / 100D)), 0) + ",to: " + Math.Round((this.Max * (metasOrder[i].Valor / 100D)), 0) + ",color: '" + metasOrder[i].CorHex + "'} ");
                if (i < metas.Count() - 1)
                {
                    SB.AppendLine(",");
                }
                else
                {
                    SB.AppendLine(",                 {from: " + Math.Round((this.Max * (metasOrder[i].Valor / 100D)), 0) + ",to: " + this.Max + ",color: '" + metasOrder[i].CorHex + "'} ");
                }
            }

            SB.AppendLine("			]");
            SB.AppendLine("		},");
            SB.AppendLine("");
            SB.AppendLine("series: [{");
            SB.AppendLine("		    name: 'Atingido',");
            SB.AppendLine("		    data: ["+this.Value+"],");
            SB.AppendLine("		    tooltip: {");
            SB.AppendLine("			valueSuffix: ' '");
            SB.AppendLine("		    }");
            SB.AppendLine("		}]");
            SB.AppendLine("");
            SB.AppendLine("	    });");
            SB.AppendLine("	});");
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
