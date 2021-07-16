using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text.pdf.draw;

namespace LnSmithWinApp
{
    public partial class Form1 : Form
    {
        List<OrnamentDetails> ornaments = new List<OrnamentDetails>();
        bool isAddnew = false;
        int Id = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMobileNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGeneratePdf_Click(object sender, EventArgs e)
        {
            if (ValidateUserFields())
            {
                string relation = ddRelationType.SelectedItem.ToString();
                string relationName = txtRelationName.Text + " ";
                string address = txtAddress.Text + " ";
                decimal marketRate = Convert.ToDecimal(txtTodayRate.Text);
                string bank = ddBank.SelectedItem + " ";
                string branch = txtBranch.Text == "" ? "" : txtBranch.Text;
                string Name = txtName.Text;
                //string mobileNumber = txtMobileNumber.Text;

                Document document = new Document(PageSize.A4, 20, 20, 20, 10);

                var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);

                PdfWriter.GetInstance(document, new FileStream("D:/Pdf/" + Name + "Estimation.pdf", FileMode.Create));
                document.Open();
                document.NewPage();

                //Annexture
                Paragraph annexture = new Paragraph("Annexure - PL-62");
                annexture.Alignment = Element.ALIGN_RIGHT;
                annexture.Font.Size = 14;
                document.Add(annexture);

                //Header
                Paragraph headerCert = new Paragraph("APPRAISER CERTIFICATE");
                headerCert.Alignment = Element.ALIGN_CENTER;
                headerCert.Font.Size = 16;
                headerCert.Font.SetStyle(4); //4 is for under line, 1 is for Bold, 
                document.Add(headerCert);

                //Bank Manager and Branch
                Paragraph toPara = new Paragraph("To");
                toPara.Alignment = Element.ALIGN_LEFT;
                toPara.Font.Size = 12;
                document.Add(toPara);

                Paragraph managerPara = new Paragraph("The Branch Manager");
                managerPara.Alignment = Element.ALIGN_LEFT;
                managerPara.Font.Size = 12;
                document.Add(managerPara);

                Paragraph bankPara = new Paragraph("State Bank of India");
                bankPara.Alignment = Element.ALIGN_LEFT;
                bankPara.Font.Size = 12;
                document.Add(bankPara);


                Chunk chunk1 = new Chunk(branch, boldFont);
                chunk1.SetUnderline(1, -3);
                //document.Add(new Phrase(chunk1));
                Chunk chunk2 = new Chunk(" Branch.");
                //chunk2.SetUnderline(2, 3);
                //document.Add(new Phrase(chunk2));
                Paragraph paraBranch = new Paragraph();
                paraBranch.Add(chunk1);
                paraBranch.Add(new Phrase(chunk2));
                PdfPTable tableAccount = new PdfPTable(2);
                tableAccount.WidthPercentage = 100;
                tableAccount.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                tableAccount.AddCell(paraBranch);

                string Account = "AC.No.________________";
                PdfPCell cellAcNo = new PdfPCell();
                cellAcNo.Border = iTextSharp.text.Rectangle.NO_BORDER;
                Paragraph acPara = new Paragraph(Account);
                acPara.Alignment = Element.ALIGN_RIGHT;
                cellAcNo.AddElement(acPara);
                tableAccount.AddCell(cellAcNo);

                document.Add(tableAccount);

                document.Add(new Paragraph("\n"));

                Paragraph dearPara = new Paragraph("Dear Sir,");
                dearPara.Alignment = Element.ALIGN_LEFT;
                dearPara.Font.Size = 12;
                document.Add(dearPara);

                document.Add(new Paragraph("\n"));


                Chunk chunk3 = new Chunk("I hereby certify that Sri / Smt ");
                //chunk1.SetUnderline(2, -3);
                document.Add(new Phrase(chunk3));

                Chunk chunk4 = new Chunk(Name + " ", boldFont);
                chunk4.SetUnderline(1, -3);
                document.Add(new Phrase(chunk4));

                Chunk chunk5 = new Chunk(relation + "  ");
                //chunk1.SetUnderline(2, -3);
                document.Add(new Phrase(chunk5));

                Chunk chunk6 = new Chunk(relationName, boldFont);
                chunk6.SetUnderline(1, -3);
                document.Add(new Phrase(chunk6));

                Chunk chunk7 = new Chunk("Resident of ");
                document.Add(new Phrase(chunk7));

                Chunk chunk8 = new Chunk(address, boldFont);
                chunk8.SetUnderline(1, -3);
                document.Add(new Phrase(chunk8));

                Chunk chunk9 = new Chunk(" who has sought gold loan from the Bank is not my relative and the gold against which the loan is sought is not purchased from me. The ornaments/Coins have been weighted and appraised by me on ");
                document.Add(new Phrase(chunk9));

                Chunk chunk10 = new Chunk(DateTime.Now.ToString("dd/MMM/yyyy"), boldFont);
                chunk10.SetUnderline(1, -3);
                document.Add(new Phrase(chunk10));


                Chunk chunk11 = new Chunk(" in the presence of Sri/ Smt ");
                document.Add(new Phrase(chunk11));

                Chunk chunk12 = new Chunk("                   ");
                chunk12.SetUnderline(1, -3);
                document.Add(new Phrase(chunk12));

                Chunk chunk13 = new Chunk(" (Cash in charge) and the exact weight, purity of the metal and market value of each item as on date are indicated below: ");
                document.Add(new Phrase(chunk13));

                document.Add(new Paragraph("\n"));

                Chunk chunk14 = new Chunk("Market rate per Gram : Rs: ");
                document.Add(new Phrase(chunk14));

                Chunk chunk15 = new Chunk(marketRate.ToString("0.##"), boldFont);
                chunk15.SetUnderline(1, -3);
                document.Add(new Phrase(chunk15));


                PdfPTable tableOrnaments = new PdfPTable(7);
                tableOrnaments.WidthPercentage = 100;
                tableOrnaments.HeaderRows = 1;

                PdfPCell cellSno = new PdfPCell();
                Paragraph snoPara = new Paragraph("S.No");
                snoPara.Font.SetStyle(1);
                cellSno.AddElement(snoPara);
                tableOrnaments.AddCell(cellSno);

                PdfPCell cellDesc = new PdfPCell();
                Paragraph descPara1 = new Paragraph("Description of");
                Paragraph descPara2 = new Paragraph("the article");
                descPara1.Alignment = Element.ALIGN_CENTER;
                descPara2.Alignment = Element.ALIGN_CENTER;
                descPara1.Font.SetStyle(1);
                descPara2.Font.SetStyle(1);
                cellDesc.AddElement(descPara1);
                cellDesc.AddElement(descPara2);
                tableOrnaments.AddCell(cellDesc);

                PdfPCell cellGrossWeight = new PdfPCell();
                Paragraph paraGross1 = new Paragraph("Gross ");
                Paragraph paraGross2 = new Paragraph("Weight");
                paraGross1.Alignment = Element.ALIGN_CENTER;
                paraGross2.Alignment = Element.ALIGN_CENTER;
                paraGross1.Font.SetStyle(1);
                paraGross2.Font.SetStyle(1);
                cellGrossWeight.AddElement(paraGross1);
                cellGrossWeight.AddElement(paraGross2);
                tableOrnaments.AddCell(cellGrossWeight);

                PdfPCell cellApprox = new PdfPCell();
                Paragraph paraApprox1 = new Paragraph("Approximate weight of the precious stones in ");
                Paragraph paraApprox2 = new Paragraph("the ornaments (Grams)");
                paraApprox1.Alignment = Element.ALIGN_CENTER;
                paraApprox2.Alignment = Element.ALIGN_CENTER;
                paraApprox1.Font.SetStyle(1);
                paraApprox2.Font.SetStyle(1);
                cellApprox.AddElement(paraApprox1);
                cellApprox.AddElement(paraApprox2);
                tableOrnaments.AddCell(cellApprox);

                PdfPCell cellPurity = new PdfPCell();
                Paragraph paraPurity1 = new Paragraph("Purity");
                Paragraph paraPurity2 = new Paragraph("(Carat)");
                paraPurity1.Alignment = Element.ALIGN_CENTER;
                paraPurity2.Alignment = Element.ALIGN_CENTER;
                paraPurity1.Font.SetStyle(1);
                paraPurity2.Font.SetStyle(1);
                cellPurity.AddElement(paraPurity1);
                cellPurity.AddElement(paraPurity2);
                tableOrnaments.AddCell(cellPurity);

                PdfPCell cellNet = new PdfPCell();
                Paragraph paraNet1 = new Paragraph("Net Weight");
                Paragraph paraNet2 = new Paragraph("(Grams)");
                paraNet1.Alignment = Element.ALIGN_CENTER;
                paraNet2.Alignment = Element.ALIGN_CENTER;
                paraNet1.Font.SetStyle(1);
                paraNet2.Font.SetStyle(1);
                cellNet.AddElement(paraNet1);
                cellNet.AddElement(paraNet2);
                tableOrnaments.AddCell(cellNet);

                PdfPCell cellMarket = new PdfPCell();
                Paragraph paraMarket1 = new Paragraph("Market");
                Paragraph paraMarket2 = new Paragraph("Value Rs.");
                paraMarket1.Alignment = Element.ALIGN_CENTER;
                paraMarket2.Alignment = Element.ALIGN_CENTER;
                paraMarket1.Font.SetStyle(1);
                paraMarket2.Font.SetStyle(1);
                cellMarket.AddElement(paraMarket1);
                cellMarket.AddElement(paraMarket2);
                tableOrnaments.AddCell(cellMarket);

                decimal GW = 0;
                decimal SW = 0;
                decimal NW = 0;
                decimal MP = 0;
                int total = 0;
                int Sno = 0;
                foreach (var item in ornaments)
                {
                    GW += item.GrossWeight;
                    SW += item.StoneWeight;
                    NW += item.NetWeight;
                    MP += item.MarketPrice;
                    total += item.Quantity;
                    Sno += 1;

                    PdfPCell cellSn = new PdfPCell();
                    Paragraph paraSN = new Paragraph(Sno.ToString());
                    paraSN.Alignment = Element.ALIGN_CENTER;
                    cellSn.AddElement(paraSN);
                    tableOrnaments.AddCell(cellSn);
                   

                    PdfPCell cellORN = new PdfPCell();
                    Paragraph paraORN = new Paragraph(item.Ornament + "(" + item.Quantity + ")");
                    paraORN.Alignment = Element.ALIGN_CENTER;
                    cellORN.AddElement(paraORN);
                    tableOrnaments.AddCell(cellORN);

                    PdfPCell cellGWeight = new PdfPCell();
                    Paragraph paraGWeight = new Paragraph(item.GrossWeight.ToString("########.000"));
                    paraGWeight.Alignment = Element.ALIGN_CENTER;
                    cellGWeight.AddElement(paraGWeight);
                    tableOrnaments.AddCell(cellGWeight);

                    PdfPCell cellSWeight = new PdfPCell();
                    Paragraph paraSWeight = new Paragraph(item.StoneWeight.ToString("########.000"));
                    paraSWeight.Alignment = Element.ALIGN_CENTER;
                    cellSWeight.AddElement(paraSWeight);
                    tableOrnaments.AddCell(cellSWeight);

                    PdfPCell cellCarat = new PdfPCell();
                    Paragraph paraCarat = new Paragraph("22");
                    paraCarat.Alignment = Element.ALIGN_CENTER;
                    cellCarat.AddElement(paraCarat);
                    tableOrnaments.AddCell(cellCarat);

                    PdfPCell cellNweight = new PdfPCell();
                    Paragraph paraNWeight = new Paragraph(item.NetWeight.ToString("########.000"));
                    paraNWeight.Alignment = Element.ALIGN_CENTER;
                    cellNweight.AddElement(paraCarat);
                    tableOrnaments.AddCell(cellNweight);

                    PdfPCell cellMPrice = new PdfPCell();
                    Paragraph paraMPrice = new Paragraph(item.NetWeight.ToString("########.00"));
                    paraMPrice.Alignment = Element.ALIGN_CENTER;
                    cellMPrice.AddElement(paraMPrice);
                    tableOrnaments.AddCell(cellMPrice);

                    //tableOrnaments.AddCell(Sno.ToString());
                    //tableOrnaments.AddCell(item.Ornament + "(" + item.Quantity + ")");
                    //tableOrnaments.AddCell(item.GrossWeight.ToString("0.###"));
                    //tableOrnaments.AddCell(item.StoneWeight.ToString("0.###"));
                    //tableOrnaments.AddCell("22");
                    //tableOrnaments.AddCell(item.NetWeight.ToString("0.###"));
                    //tableOrnaments.AddCell(item.MarketPrice.ToString("0.###"));
                }
                tableOrnaments.AddCell("");

                PdfPCell cellTotal = new PdfPCell();
                Paragraph paraTotal = new Paragraph("Total(" + total + ")");
                paraTotal.Alignment = Element.ALIGN_CENTER;
                cellTotal.AddElement(paraTotal);
                tableOrnaments.AddCell(cellTotal);

                //tableOrnaments.AddCell("Total(" + total + ")");

                PdfPCell cellGW = new PdfPCell();
                Paragraph chunkGW = new Paragraph(GW.ToString("########.000"), boldFont);
                chunkGW.Alignment = Element.ALIGN_CENTER;
                //chunkGW.Font.SetStyle(1);
                chunkGW.Font.SetStyle(4);
                cellGW.AddElement(chunkGW);
                tableOrnaments.AddCell(cellGW);

                PdfPCell cellSW = new PdfPCell();
                Paragraph chunkSW = new Paragraph(SW.ToString("########.000"), boldFont);
                chunkSW.Alignment = Element.ALIGN_CENTER;
                //chunkSW.Font.SetStyle(1);
                chunkSW.Font.SetStyle(4);
                cellSW.AddElement(chunkSW);
                tableOrnaments.AddCell(cellSW);

                tableOrnaments.AddCell("");

                PdfPCell cellNw = new PdfPCell();
                Paragraph chunkNW = new Paragraph(NW.ToString("########.000"), boldFont);
                chunkNW.Alignment = Element.ALIGN_CENTER;
                //chunkNW.Font.SetStyle(1);
                chunkNW.Font.SetStyle(4);
                cellNw.AddElement(chunkNW);
                tableOrnaments.AddCell(cellNw);

                PdfPCell cellMP = new PdfPCell();
                Paragraph chunkMP = new Paragraph(MP.ToString("########.00"), boldFont);
                chunkMP.Alignment = Element.ALIGN_CENTER;
                //chunkMP.Font.SetStyle(1);
                chunkMP.Font.SetStyle(4);
                cellMP.AddElement(chunkMP);
                tableOrnaments.AddCell(cellMP);

                float[] widths = new float[] { 7, 20, 11, 40, 11, 17, 15 };
                tableOrnaments.SetWidths(widths);
                document.Add(tableOrnaments);

                document.Add(new Paragraph("\n"));

                Paragraph lastPara = new Paragraph("I Solemnly declare that weight, purity of the gold ornaments/precious stones indicated above are correct and Iunder take to indemnify the Bank against any loss it may sustain on account of any inaccuracy in the above appraisal.");
                dearPara.Alignment = Element.ALIGN_LEFT;
                dearPara.Font.Size = 12;
                document.Add(lastPara);

                document.Add(new Paragraph("\n\n"));

                PdfPTable tableFooter = new PdfPTable(2);
                tableFooter.WidthPercentage = 100;
                tableFooter.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                tableFooter.AddCell("Place: " + branch);

                PdfPCell cellFaith = new PdfPCell();
                cellFaith.Border = iTextSharp.text.Rectangle.NO_BORDER;
                Paragraph faithPara = new Paragraph("Yours Faithfully");
                faithPara.Alignment = Element.ALIGN_RIGHT;
                cellFaith.AddElement(faithPara);
                tableFooter.AddCell(cellFaith);

                tableFooter.AddCell("Date: " + DateTime.Now.ToString("dd/MMM/yyyy"));

                PdfPCell cellAppraiser = new PdfPCell();
                cellAppraiser.Border = iTextSharp.text.Rectangle.NO_BORDER;
                Paragraph appraiserPara = new Paragraph("Appraiser");
                appraiserPara.Alignment = Element.ALIGN_RIGHT;
                cellAppraiser.AddElement(appraiserPara);
                tableFooter.AddCell(cellAppraiser);

                document.Add(tableFooter);

                Paragraph signBarrowerPara = new Paragraph("Signature of the Borrower");
                signBarrowerPara.Alignment = Element.ALIGN_CENTER;
                signBarrowerPara.Font.Size = 12;
                document.Add(signBarrowerPara);

                document.Close();

                isAddnew = true;
                ClearOrnamentDetails();
                isAddnew = false;
                CleaerUserDetails();

                ornaments = new List<OrnamentDetails>();
                gridOrnaments.DataSource = null;
            }
            else
            {
                MessageBox.Show("Please enter all mandatory fields.");
            }
        }

        public void ClearOrnamentDetails()
        {
            txtOrnament.Text = "";
            txtGrossWeight.Text = "";
            txtStoneWeight.Text = "";
            txtQuality.Text = "";
            txtNetWeight.Text = "";
            txtMarketPrice.Text = "";
            ddQuantity.SelectedIndex = -1;
        }

        public void CleaerUserDetails()
        {
            txtBranch.Text = "";
            txtName.Text = "";
            txtRelationName.Text = "";
            txtAddress.Text = "";
            //txtMobileNumber.Text = "";
            ddBank.SelectedIndex = -1;
            ddRelationType.SelectedIndex = -1;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (ValidateOrnamentFields())
            {
                isAddnew = true;
                OrnamentDetails ornament = new OrnamentDetails();
                int id = ornaments.Count > 0 ? ornaments.Count + 1 : 1;

                ornament = ornaments.FirstOrDefault(x => x.Id == Id);
                if (ornament != null)
                {
                    ornaments.Remove(ornament);
                    ornament.Id = Id;
                    ornament.Ornament = txtOrnament.Text;
                    ornament.Quantity = Convert.ToInt32(ddQuantity.SelectedItem);
                    ornament.GrossWeight = Convert.ToDecimal(txtGrossWeight.Text);
                    if(txtStoneWeight.Text != "")
                    {
                        ornament.StoneWeight = Convert.ToDecimal(txtStoneWeight.Text);
                    }
                    else
                    {
                        ornament.StoneWeight = Convert.ToDecimal(0);
                    }
                    //ornament.StoneWeight = Convert.ToDecimal(txtStoneWeight.Text != "" ? txtStoneWeight.Text : 0);
                    ornament.Quality = Convert.ToInt32(txtQuality.Text);
                    ornament.NetWeight = Convert.ToDecimal(txtNetWeight.Text);
                    ornament.MarketPrice = Convert.ToDecimal(txtMarketPrice.Text);

                    ornaments.Add(ornament);
                }
                else
                {
                    ornament = new OrnamentDetails();
                    ornament.Id = id;
                    ornament.Ornament = txtOrnament.Text;
                    ornament.Quantity = Convert.ToInt32(ddQuantity.SelectedItem);
                    ornament.GrossWeight = Convert.ToDecimal(txtGrossWeight.Text);
                    if (txtStoneWeight.Text != "")
                    {
                        ornament.StoneWeight = Convert.ToDecimal(txtStoneWeight.Text);
                    }
                    else
                    {
                        ornament.StoneWeight = Convert.ToDecimal(0);
                    }
                    //ornament.StoneWeight = Convert.ToDecimal(txtStoneWeight.Text != "" ? txtStoneWeight.Text : 0);
                    ornament.Quality = Convert.ToInt32(txtQuality.Text);
                    ornament.NetWeight = Convert.ToDecimal(txtNetWeight.Text);
                    ornament.MarketPrice = Convert.ToDecimal(txtMarketPrice.Text);
                    ornaments.Add(ornament);
                }

                gridOrnaments.DataSource = null;
                gridOrnaments.DataSource = ornaments.OrderBy(X => X.Id).ToList();
                //gridOrnaments.Refresh();
                ClearOrnamentDetails();
                isAddnew = false;
            }
            else
            {
                MessageBox.Show("Please enter all mandatory fields.");
            }
        }

        private void txtQuality_TextChanged(object sender, EventArgs e)
        {
            if (isAddnew == false)
            {
                CalculatePrice();
            }
        }

        public void CalculatePrice()
        {
            if (txtQuality.Text != "" && txtGrossWeight.Text != "")
            {
                var grosswt = Convert.ToDecimal(txtGrossWeight.Text);
                var stonewt = Convert.ToDecimal(txtStoneWeight.Text != "" ? txtStoneWeight.Text : "0");
                var qulty = Convert.ToInt32(txtQuality.Text);

                var weight = (grosswt - stonewt) * (qulty / 100m);
                var netWeight = weight + ((weight * 8) / 100m);
                txtNetWeight.Text = netWeight.ToString();

                var todayRate = Convert.ToDecimal(txtTodayRate.Text);
                var marketPrice = netWeight * todayRate;
                txtMarketPrice.Text = marketPrice.ToString();
            }

        }

        private void gridOrnaments_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OrnamentDetails ornament = new OrnamentDetails();
            Id = Convert.ToInt32(gridOrnaments.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtOrnament.Text = gridOrnaments.Rows[e.RowIndex].Cells[1].Value.ToString();
            ddQuantity.SelectedText = gridOrnaments.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtGrossWeight.Text = gridOrnaments.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtStoneWeight.Text = gridOrnaments.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtQuality.Text = gridOrnaments.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtNetWeight.Text = gridOrnaments.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtMarketPrice.Text = gridOrnaments.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void txtGrossWeight_TextChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void txtStoneWeight_TextChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }
        public bool ValidateOrnamentFields()
        {
            bool IsValid = true;
            if (txtOrnament.Text == "" || ddQuantity.SelectedItem == null || txtGrossWeight.Text == "" || txtQuality.Text == "" || txtNetWeight.Text == "" || txtMarketPrice.Text == "")
            {
                IsValid = false;
            }
            return IsValid;
        }
        public bool ValidateUserFields()
        {
            bool IsValid = true;
            if (txtTodayRate.Text == "" || ddBank.SelectedItem == null || txtBranch.Text == "" || txtName.Text == "" || ddRelationType.SelectedItem == null || txtRelationName.Text == "" || txtAddress.Text == "")
            {
                IsValid = false;
            }          
            return IsValid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrnamentDetails ornament = ornaments.FirstOrDefault(x => x.Id == Id);
            if (ornament != null)
            {
                ornaments.Remove(ornament);
                gridOrnaments.DataSource = null;
                gridOrnaments.DataSource = ornaments.OrderBy(X => X.Id).ToList();
                //gridOrnaments.Refresh();
                MessageBox.Show("Deleted Successfully");
                ClearOrnamentDetails();
            }
        }
    }
}
