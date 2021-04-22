using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfDocument = iText.Kernel.Pdf.PdfDocument;
using PdfFont = iText.Kernel.Font.PdfFont;
using PdfWriter = iText.Kernel.Pdf.PdfWriter;

namespace UserInterfaceZoo
{
    public partial class PA_06_03_Orden_de_compra_totales : Form
    {
        
        public PA_06_03_Orden_de_compra_totales()
        {
            InitializeComponent();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
            MenuPrincipal.abrirPantallas(new PA_06_02_Orden_de_compra_registro_articulos());
            MenuPrincipal.AsignarTitulo("Orden de compra registro artículos");
            this.Close();

        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            crearPDF();
            MessageBox.Show("Reporte creado exitosamente", "Orden de compra");
            this.Close();
            MenuPrincipal.abrirPantallas(new PA_06_01_Orden_de_compra_informacion());


        }

        private void crearPDF()
        {
            PA_06_01_Orden_de_compra_informacion a = new PA_06_01_Orden_de_compra_informacion();


            PdfWriter pdfWriter = new PdfWriter("ReporteOC.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);

            Document documento = new Document(pdf, PageSize.LETTER);
            documento.SetMargins(60,40,55,40);

            PdfFont fontTitulos = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLDITALIC);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);

            Text tituloP = new Text("REPORTE ORDEN DE COMPRA").SetFont(fontTitulos).SetFontSize(20);
            Paragraph p = new Paragraph().Add(tituloP);
            p.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);

            //Información de empresa

            Text tituloInfo = new Text("Información de la empresa").SetFont(fontTitulos).SetFontSize(16);
            Paragraph tInfo = new Paragraph().Add(tituloInfo);
            tInfo.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);

            Text Pantalla1 = new Text(lblDatosP3.Text).SetFont(fontContenido).SetFontSize(12);
            Paragraph infoE = new Paragraph().Add(Pantalla1);
            infoE.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);



            //Fechas orden de compra

            Text tituloFechas = new Text("Fechas orden de compra").SetFont(fontTitulos).SetFontSize(16);
            Paragraph tfecha = new Paragraph().Add(tituloFechas);
            tfecha.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);

            Text fEmision = new Text("Fecha de emisión: " + lblFechaRecp_p3.Text).SetFont(fontContenido).SetFontSize(12);
            Paragraph fechaEmi = new Paragraph().Add(fEmision);
            fechaEmi.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);

            Text nOrden = new Text("Número de orden: " + lblNoOrden_p3.Text).SetFont(fontContenido).SetFontSize(12);
            Paragraph orden = new Paragraph().Add(nOrden);
            orden.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);

            Text fRecep = new Text("Fecha de recepción: " + dateTimeRecp_p3.Text).SetFont(fontContenido).SetFontSize(12);
            Paragraph recep = new Paragraph().Add(fRecep);
            recep.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);

            Text fPago = new Text("Fecha de pago: " + dateTimePago_p3.Text).SetFont(fontContenido).SetFontSize(12);
            Paragraph pago = new Paragraph().Add(fPago);
            pago.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);


            //Proveedor

            Text tituloProv = new Text("Proveedor").SetFont(fontTitulos).SetFontSize(16);
            Paragraph tProv = new Paragraph().Add(tituloProv);
            tProv.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);

            Text compañia = new Text("Compañia: " + lblCompaProv_p3.Text).SetFont(fontContenido).SetFontSize(12);
            Paragraph compa = new Paragraph().Add(compañia);
            compa.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);

            Text contacto = new Text("Contacto: " + lblContacto_p3.Text).SetFont(fontContenido).SetFontSize(12);
            Paragraph pContacto = new Paragraph().Add(contacto);
            pContacto.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);

            Text cargo = new Text("Cargo: " + lblCargo_p3.Text).SetFont(fontContenido).SetFontSize(12);
            Paragraph pCargo = new Paragraph().Add(cargo);
            pCargo.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);

            Text domicilio = new Text("Domicilio: " + lblDomProv_p3.Text).SetFont(fontContenido).SetFontSize(12);
            Paragraph pDomiclio = new Paragraph().Add(domicilio);
            pDomiclio.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);

            Text telefono = new Text("Telefono: " + lblTelProv_p3.Text).SetFont(fontContenido).SetFontSize(12);
            Paragraph pTelefono = new Paragraph().Add(telefono);
            pTelefono.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);

            //Enviar a

            Text tituloEnviar = new Text("Enviar a").SetFont(fontTitulos).SetFontSize(16);
            Paragraph tEnviar = new Paragraph().Add(tituloEnviar);
            tEnviar.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);

            Text compañiaE = new Text("Compañia: " + listBoxCompa_p3.Text).SetFont(fontContenido).SetFontSize(12);
            Paragraph compaE = new Paragraph().Add(compañiaE);
            compaE.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);

            Text departamentoE = new Text("Departamento: " + listBoxDepa_p3.Text).SetFont(fontContenido).SetFontSize(12);
            Paragraph depaE = new Paragraph().Add(departamentoE);
            depaE.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);

            Text domicilioE = new Text("Domicilio: " + lblDomDepa_p3.Text).SetFont(fontContenido).SetFontSize(12);
            Paragraph domE = new Paragraph().Add(domicilioE);
            domE.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);

            Text telefonoE = new Text("Telefono: " + lblTelDepa_p3.Text).SetFont(fontContenido).SetFontSize(12);
            Paragraph telE = new Paragraph().Add(telefonoE);
            telE.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);


            //Tabla


            Text tituloArticulos = new Text("Articulos").SetFont(fontTitulos).SetFontSize(16);
            Paragraph tArt = new Paragraph().Add(tituloArticulos);
            tArt.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);

            string[] columnas = { "Número/Nombre", "Descripción", "Cantidad", "Precio Unitorio", "Total" };

            float[] tamanios = { 2, 4, 2, 2, 4 };

            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }


            tabla.AddCell(txtNumArt_p3.Text);
            tabla.AddCell(lblDescArt_p3.Text);
            tabla.AddCell(txtCant_p3.Text);
            tabla.AddCell(lblPUnitario_p3.Text);
            tabla.AddCell(lblTotal_p3.Text);

            //Totales

            Text tituloTotales = new Text("Totales").SetFont(fontTitulos).SetFontSize(16);
            Paragraph tTotal = new Paragraph().Add(tituloTotales);
            tTotal.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);

            Text subtotal = new Text("Subtotal: " + lblSubtotal.Text).SetFont(fontContenido).SetFontSize(12);
            Paragraph tSubtotal = new Paragraph().Add(subtotal);
            tSubtotal.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);

            Text descuento = new Text("Descuento %: " + txtDescuento.Text).SetFont(fontContenido).SetFontSize(12);
            Paragraph tDescuento = new Paragraph().Add(descuento);
            tDescuento.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);

            Text subDesc = new Text("Subtotal - Descuento: " + lblSubtotalDescuento.Text).SetFont(fontContenido).SetFontSize(12);
            Paragraph tSubDesc = new Paragraph().Add(subDesc);
            tSubDesc.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);

            Text TasaImp = new Text("Tasa de impuestos: " + lblTasaImpuestos.Text).SetFont(fontContenido).SetFontSize(12);
            Paragraph tTasaImp = new Paragraph().Add(TasaImp);
            tTasaImp.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);

            Text totalImp = new Text("Total con impuestos: " + lblTotalImpuestos.Text).SetFont(fontContenido).SetFontSize(12);
            Paragraph tTotalImp = new Paragraph().Add(totalImp);
            tTotalImp.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);

            Text envio = new Text("Envió/Almacenaje: " + lblEnvioAlmacen.Text).SetFont(fontContenido).SetFontSize(12);
            Paragraph EnvioAlm = new Paragraph().Add(envio);
            EnvioAlm.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);

            Text totalF = new Text("Total: " + lblGranTotal.Text).SetFont(fontContenido).SetFontSize(12);
            Paragraph totalFinal = new Paragraph().Add(totalF);
            totalFinal.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);


            //Responsable
            Text respon = new Text("Responsable: " + txtResponsable.Text).SetFont(fontContenido).SetFontSize(12);
            Paragraph responsable = new Paragraph().Add(respon);
            responsable.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);

            //Observaciones
            Text observ = new Text("Notas/Observaciones: " + rtbObservaciones.Text).SetFont(fontContenido).SetFontSize(12);
            Paragraph notasObserv = new Paragraph().Add(observ);
            notasObserv.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);


            //Información de empresa
            documento.Add(p);
            documento.Add(tInfo);
            documento.Add(infoE);
            //Fechas orden de compra
            documento.Add(tfecha);
            documento.Add(fechaEmi);
            documento.Add(orden);
            documento.Add(recep);
            documento.Add(pago);
            //Proveedor
            documento.Add(tProv);
            documento.Add(compa);
            documento.Add(pContacto);
            documento.Add(pCargo);
            documento.Add(pDomiclio);
            documento.Add(pTelefono);
            //Enviar a
            documento.Add(tEnviar);
            documento.Add(compaE);
            documento.Add(depaE);
            documento.Add(domE);
            documento.Add(telE);
            //Agregar articulos
            documento.Add(tArt);
            documento.Add(tabla);
            //Totales
            documento.Add(tTotal);
            documento.Add(tSubtotal);
            documento.Add(tDescuento);
            documento.Add(tSubDesc);
            documento.Add(tTasaImp);
            documento.Add(tTotalImp);
            documento.Add(EnvioAlm);
            documento.Add(totalFinal);
            //Responsable Notas
            documento.Add(responsable);
            documento.Add(notasObserv);
            documento.Close();
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            double descuento = Convert.ToDouble(txtDescuento.Text);
            descuento = descuento / 100;
            int total = Convert.ToInt32(lblSubtotal.Text);

            lblSubtotalDescuento.Text = Convert.ToString(descuento*total);
            double subtotal = Convert.ToDouble(lblSubtotalDescuento.Text);
            double iva = 0.16;
            lblTotalImpuestos.Text = Convert.ToString(subtotal*iva+(subtotal));
            lblTasaImpuestos.Text = "16";
            double tasaImpuesto = Convert.ToDouble(lblTasaImpuestos.Text);

            double totalImpuestos = Convert.ToDouble(lblTotalImpuestos.Text);
            lblEnvioAlmacen.Text = Convert.ToString(totalImpuestos * 0.25 + tasaImpuesto);

            double grantotal = Convert.ToDouble(lblEnvioAlmacen.Text);
            lblGranTotal.Text = Convert.ToString(grantotal + totalImpuestos);
        }
    }
}
