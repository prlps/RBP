using JewelryWorkshop.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;




namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private AppDbContext _dbContext;

        public Form1()
        {
            InitializeComponent();
            btnGenerateHtmlCombined.Click += (s, e) => GenerateHtmlCombinedReport_GroupByMaterial();
            btnGenerateHtmlCatalog.Click += (s, e) => GenerateHtmlCatalogReport();
            _dbContext = new AppDbContext();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _dbContext.Database.EnsureCreated();

            _dbContext.Materials.Load();
            materialDataView.DataSource = _dbContext.Materials.Local.ToBindingList();
            _dbContext.Products.Load();
            productDataView.DataSource = _dbContext.Products.Local.ToBindingList();
            _dbContext.Sales.Load();
            saleDataView.DataSource = _dbContext.Sales.Local.ToBindingList();
        }
        //Отображение информации
        private void materialDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (materialDataView.CurrentRow == null) return;
            Material material = materialDataView.CurrentRow.DataBoundItem as Material;
            if (material == null) return;
            tb_ID.Text = material.Id.ToString();
            tb_Material.Text = material.Name;
        }
        private void productDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productDataView.CurrentRow == null) return;
            Product product = productDataView.CurrentRow.DataBoundItem as Product;
            if (product == null) return;
            tb_proID.Text = product.Id.ToString();
            tb_proName.Text = product.Name;
            tb_proType.Text = product.Type;
            tb_proMat.Text = product.Material.Id.ToString();
            tb_proPrice.Text = product.Price.ToString();
            tb_proWei.Text = product.Weight.ToString();
        }
        private void saleDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (saleDataView.CurrentRow == null) return;
            Sale sale = saleDataView.CurrentRow.DataBoundItem as Sale;
            if (sale == null) return;
            tb_saleID.Text = sale.Id.ToString();
            tb_saleFirst.Text = sale.FirstName.ToString();
            tb_saleLast.Text = sale.LastName.ToString();
            tb_saleMidd.Text = sale.MiddleName.ToString();
            tb_saleProd.Text = sale.ProductId.ToString();
            tb_saleDate.Text = sale.SaleDate.ToString();
        }
        //Добавление
        private void MatAdd_Click(object sender, EventArgs e)
        {
            if (tb_Material.Text == String.Empty || tb_ID.Text == String.Empty)
            {
                MessageBox.Show("Заполните данные о матерале");
                return;
            }
            Material material = new Material
            {
                Name = tb_Material.Text
            };
            _dbContext.Materials.Add(material);
            _dbContext.SaveChanges();
            materialDataView.Refresh();
            tb_Material.Text = String.Empty;
        }
        private void prodAdd_Click(object sender, EventArgs e)
        {
            if (tb_proName.Text == String.Empty || tb_proID.Text == String.Empty)
            {
                MessageBox.Show("Ну заполни ты данные уже! Мне их из воздуха брать? :<");
                return;
            }
            Product product = new Product
            {
                Name = tb_proName.Text,
                Type = tb_proType.Text,
                Weight = double.Parse(tb_proWei.Text),
                Price = decimal.Parse(tb_proPrice.Text),
                MaterialId = int.Parse(tb_proMat.Text)
            };
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            productDataView.Refresh();
            tb_proName.Text = String.Empty;

        }
        private void saleAdd_Click(object sender, EventArgs e)
        {
            if (tb_saleFirst.Text == String.Empty || tb_saleLast.Text == String.Empty || tb_saleMidd.Text == String.Empty || tb_saleID.Text == String.Empty)
            {
                MessageBox.Show("Ну заполни ты данные уже! Мне их из воздуха брать? :<");
                return;
            }
            Sale sale = new Sale
            {
                SaleDate = DateTime.Parse(tb_saleDate.Text).ToUniversalTime(),
                LastName = tb_saleLast.Text,
                FirstName = tb_saleFirst.Text,
                MiddleName = tb_saleLast.Text,
                Id = int.Parse(tb_saleID.Text),
                ProductId = int.Parse(tb_saleProd.Text),
            };
            _dbContext.Sales.Add(sale);
            _dbContext.SaveChanges();
            saleDataView.Refresh();
            tb_saleFirst.Text = String.Empty;
        }
        //Редактирование
        private void MatEdit_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text == String.Empty) return;
            int Id = Convert.ToInt32(tb_ID.Text);
            Material material = _dbContext.Materials.Find(Id);
            if (material == null) return;
            material.Name = tb_Material.Text;
            _dbContext.Materials.Update(material);
            _dbContext.SaveChanges();
            materialDataView.Refresh();

        }
        private void prodRed_Click(object sender, EventArgs e)
        {
            if (tb_proID.Text == String.Empty) return;
            int Id = Convert.ToInt32(tb_proID.Text);
            Product product = _dbContext.Products.Find(Id);
            if (product == null) return;
            product.Name = tb_proName.Text;
            product.Type = tb_proType.Text;
            product.MaterialId = int.Parse(tb_proMat.Text); //"The input string 'Серебряный грамм карат 99' was not in a correct format."
            product.Weight = double.Parse(tb_proWei.Text);
            product.Price = decimal.Parse(tb_proPrice.Text);
            _dbContext.Products.Update(product);
            _dbContext.SaveChanges();
            productDataView.Refresh();

        }
        private void saleRed_Click(object sender, EventArgs e)
        {
            if (tb_saleFirst.Text == String.Empty || tb_saleLast.Text == String.Empty || tb_saleMidd.Text == String.Empty || tb_saleID.Text == String.Empty) return;
            int Id = Convert.ToInt32(tb_saleID.Text);
            Sale sale = _dbContext.Sales.Find(Id);
            if (sale == null) return;
            sale.SaleDate = DateTime.Parse(tb_saleDate.Text);
            sale.LastName = tb_saleFirst.Text;
            sale.FirstName = tb_saleLast.Text;
            sale.MiddleName = tb_saleMidd.Text;
            sale.ProductId = int.Parse(tb_saleID.Text);
        }

        //Удаление
        private void matDel_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text == String.Empty) return;
            int Id = Convert.ToInt32(tb_ID.Text);
            Material material = _dbContext.Materials.Find(Id);
            if (material == null) return;
            _dbContext.Materials.Remove(material);
            _dbContext.SaveChanges();
            materialDataView.Refresh();
        }
        private void prodDel_Click(Object sender, EventArgs e)
        {
            if (tb_proID.Text == String.Empty) return;
            int Id = Convert.ToInt32(tb_proID.Text);
            Product product = _dbContext.Products.Find(Id);
            if (product == null) return;
            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
            productDataView.Refresh();
        }
        private void saleDel_Click(Object sender, EventArgs e)
        {
            if (tb_saleID.Text == String.Empty) return;
            int Id = Convert.ToInt32(tb_saleID.Text);
            Sale sale = _dbContext.Sales.Find(Id);
            if (sale == null) return;
            _dbContext.Sales.Remove(sale);
            _dbContext.SaveChanges();
            saleDataView.Refresh();
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            string materialFilter = tb_filterMaterial.Text.Trim().ToLower();
            string typeFilter = tb_filterType.Text.Trim().ToLower();

            var filteredProducts = _dbContext.Products
                .Include(p => p.Material)
                .Where(p =>
                    (string.IsNullOrEmpty(materialFilter) || p.Material.Name.ToLower().Contains(materialFilter)) &&
                    (string.IsNullOrEmpty(typeFilter) || p.Type.ToLower().Contains(typeFilter))
                )
                .ToList();

            productDataView.DataSource = filteredProducts;
        }
        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            productDataView.DataSource = _dbContext.Products.Local.ToBindingList();
        }

        private void productDataView_SelectionChanged(object sender, EventArgs e)
        {
            if (productDataView.CurrentRow == null) return;
            Product selectedProduct = productDataView.CurrentRow.DataBoundItem as Product;
            if (selectedProduct == null) return;

            // Загружаем связанные продажи
            var relatedSales = _dbContext.Sales
                .Include(s => s.Product)
                .Where(s => s.ProductId == selectedProduct.Id)
                .ToList();

            saleDataView.DataSource = relatedSales;
        }
        // --- HELPERS для Word ---
        private void ReleaseCom(object comObj)
        {
            try
            {
                if (comObj != null)
                    Marshal.ReleaseComObject(comObj);
            }
            catch { }
            finally
            {
                comObj = null;
            }
        }

        private Word.Application CreateWordApp(bool visible = false)
        {
            var app = new Word.Application();
            app.Visible = visible;
            return app;
        }
        private void GenerateCombinedTableDocument(string templatePath = null)
        {
            // Получаем данные из БД
            var sales = _dbContext.Sales
                .Include(s => s.Product)
                    .ThenInclude(p => p.Material)
                .ToList();

            if (sales.Count == 0)
            {
                MessageBox.Show("Нет данных продаж для формирования документа.");
                return;
            }

            Word.Application wordApp = null;
            Word.Document doc = null;

            try
            {
                wordApp = CreateWordApp(false);

                if (!string.IsNullOrEmpty(templatePath) && File.Exists(templatePath))
                {
                    doc = wordApp.Documents.Add(templatePath);
                }
                else
                {
                    doc = wordApp.Documents.Add(); // пустой документ
                }

                // Найдём место для таблицы: bookmark TABLE_PLACE или вставим в конец
                Word.Range rangeForTable = null;
                try
                {
                    var bm = doc.Bookmarks["TABLE_PLACE"];
                    rangeForTable = bm.Range;
                }
                catch
                {
                    rangeForTable = doc.Content;
                    rangeForTable.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
                }

                // Заголовки колонок
                string[] headers = new string[] {
            "SaleId","SaleDate","LastName","FirstName","MiddleName",
            "ProductId","ProductName","ProductType","MaterialId","MaterialName","Weight","Price"
        };

                int rows = sales.Count + 1; // +1 для заголовка
                int cols = headers.Length;

                Word.Table table = doc.Tables.Add(rangeForTable, rows, cols);
                table.Borders.Enable = 1;

                // Заполняем заголовки
                for (int c = 0; c < cols; c++)
                {
                    table.Cell(1, c + 1).Range.Text = headers[c];
                    table.Cell(1, c + 1).Range.Bold = 1;
                }

                // Заполняем строки
                int r = 2;
                foreach (var s in sales)
                {
                    var p = s.Product;
                    var m = p?.Material;
                    table.Cell(r, 1).Range.Text = s.Id.ToString();
                    table.Cell(r, 2).Range.Text = s.SaleDate.ToString("yyyy-MM-dd HH:mm");
                    table.Cell(r, 3).Range.Text = s.LastName ?? "";
                    table.Cell(r, 4).Range.Text = s.FirstName ?? "";
                    table.Cell(r, 5).Range.Text = s.MiddleName ?? "";
                    table.Cell(r, 6).Range.Text = (p != null) ? p.Id.ToString() : "";
                    table.Cell(r, 7).Range.Text = p?.Name ?? "";
                    table.Cell(r, 8).Range.Text = p?.Type ?? "";
                    table.Cell(r, 9).Range.Text = (m != null) ? m.Id.ToString() : "";
                    table.Cell(r, 10).Range.Text = m?.Name ?? "";
                    table.Cell(r, 11).Range.Text = (p != null) ? p.Weight.ToString() : "";
                    table.Cell(r, 12).Range.Text = (p != null) ? p.Price.ToString() : "";
                    r++;
                }

                // --- Сохранение: явный формат, корректный обработчик отмены ---
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Word Documents|*.docx|Word 97-2003|*.doc";
                    sfd.FileName = "AllDataReport.docx";
                    sfd.AddExtension = true;
                    sfd.DefaultExt = "docx";
                    sfd.OverwritePrompt = true;

                    var dr = sfd.ShowDialog();
                    if (dr != DialogResult.OK)
                    {
                        // Пользователь отменил — закрываем без сохранения и выходим нормально
                        try
                        {
                            doc.Close(false);
                        }
                        catch { }
                        return;
                    }

                    var targetPath = sfd.FileName;
                    Word.WdSaveFormat format = Word.WdSaveFormat.wdFormatXMLDocument; // .docx
                    var ext = Path.GetExtension(targetPath)?.ToLowerInvariant();
                    if (ext == ".doc") format = Word.WdSaveFormat.wdFormatDocument;

                    try
                    {
                        // Явно указываем формат при сохранении — это убирает ошибку несовместимости типа/расширения
                        doc.SaveAs2(FileName: targetPath, FileFormat: format);
                        MessageBox.Show("Документ сохранён: " + targetPath);
                    }
                    catch (Exception ex)
                    {
                        // Если что-то пошло не так — сообщаем содержательно и закрываем документ
                        MessageBox.Show("Не удалось сохранить документ: " + ex.Message);
                        try
                        {
                            doc.Close(false);
                        }
                        catch { }
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при формировании таблицы Word: " + ex.Message);
            }
            finally
            {
                if (doc != null)
                {
                    try { doc.Close(false); } catch { }
                    ReleaseCom(doc);
                }
                if (wordApp != null)
                {
                    try { wordApp.Quit(); } catch { }
                    ReleaseCom(wordApp);
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void GenerateInvoiceForSale(int saleId, string templatePath = null)
        {
            var sale = _dbContext.Sales
                .Include(s => s.Product)
                    .ThenInclude(p => p.Material)
                .FirstOrDefault(s => s.Id == saleId);

            if (sale == null)
            {
                MessageBox.Show("Продажа с указанным Id не найдена.");
                return;
            }

            Word.Application wordApp = null;
            Word.Document doc = null;

            try
            {
                wordApp = CreateWordApp(false);

                if (!string.IsNullOrEmpty(templatePath) && File.Exists(templatePath))
                {
                    // Открываем шаблон и будем заполнять закладки, если они есть
                    doc = wordApp.Documents.Add(templatePath);

                    Action<string, string> setBookmarkText = (bookmarkName, text) =>
                    {
                        try
                        {
                            if (doc.Bookmarks.Exists(bookmarkName))
                            {
                                var bmRange = doc.Bookmarks[bookmarkName].Range;
                                bmRange.Text = text;
                                // Вставка текста удаляет bookmark — восстанавливаем его
                                object range = bmRange;
                                doc.Bookmarks.Add(bookmarkName, ref range);
                            }
                        }
                        catch { /* тихо */ }
                    };

                    var p = sale.Product;
                    var m = p?.Material;

                    setBookmarkText("INV_SaleId", sale.Id.ToString());
                    setBookmarkText("INV_Date", sale.SaleDate.ToString("yyyy-MM-dd HH:mm"));
                    setBookmarkText("INV_LastName", sale.LastName ?? "");
                    setBookmarkText("INV_FirstName", sale.FirstName ?? "");
                    setBookmarkText("INV_MiddleName", sale.MiddleName ?? "");
                    setBookmarkText("INV_ProductName", p?.Name ?? "");
                    setBookmarkText("INV_ProductType", p?.Type ?? "");
                    setBookmarkText("INV_MaterialName", m?.Name ?? "");
                    setBookmarkText("INV_Weight", (p != null) ? p.Weight.ToString() : "");
                    setBookmarkText("INV_Price", (p != null) ? p.Price.ToString() : "");
                }
                else
                {
                    // Шаблон не указан — создаём простую накладную программно
                    doc = wordApp.Documents.Add();

                    var rng = doc.Content;
                    rng.InsertAfter("НАКЛАДНАЯ / СЧЕТ\n");
                    rng.InsertParagraphAfter();
                    rng.InsertAfter($"Номер продажи: {sale.Id}\n");
                    rng.InsertAfter($"Дата: {sale.SaleDate:yyyy-MM-dd HH:mm}\n");
                    rng.InsertAfter($"Покупатель: {sale.LastName} {sale.FirstName} {sale.MiddleName}\n");
                    rng.InsertParagraphAfter();

                    // Добавим таблицу с данными изделия
                    var tblRange = doc.Content;
                    tblRange.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
                    Word.Table table = doc.Tables.Add(tblRange, 3, 2);
                    table.Borders.Enable = 1;
                    table.Cell(1, 1).Range.Text = "Поле";
                    table.Cell(1, 2).Range.Text = "Значение";

                    var p = sale.Product;
                    var m = p?.Material;
                    table.Cell(2, 1).Range.Text = "Изделие";
                    table.Cell(2, 2).Range.Text = p?.Name ?? "";
                    table.Cell(3, 1).Range.Text = "Материал / Вес / Цена";
                    table.Cell(3, 2).Range.Text = $"{m?.Name ?? ""} / {p?.Weight.ToString() ?? ""} / {p?.Price.ToString() ?? ""}";
                }

                // Сохраняем — с защитой от отмены и с указанием формата
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Word Documents|*.docx|Word 97-2003|*.doc";
                    sfd.FileName = $"Invoice_{sale.Id}.docx";
                    sfd.AddExtension = true;
                    sfd.DefaultExt = "docx";
                    sfd.OverwritePrompt = true;

                    var dr = sfd.ShowDialog();
                    if (dr != DialogResult.OK)
                    {
                        try { doc.Close(false); } catch { }
                        return;
                    }

                    var targetPath = sfd.FileName;
                    Word.WdSaveFormat format = Word.WdSaveFormat.wdFormatXMLDocument;
                    var ext = Path.GetExtension(targetPath)?.ToLowerInvariant();
                    if (ext == ".doc") format = Word.WdSaveFormat.wdFormatDocument;

                    try
                    {
                        doc.SaveAs2(FileName: targetPath, FileFormat: format);
                        MessageBox.Show("Накладная сохранена: " + targetPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не удалось сохранить накладную: " + ex.Message);
                        try { doc.Close(false); } catch { }
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании накладной: " + ex.Message);
            }
            finally
            {
                if (doc != null)
                {
                    try { doc.Close(false); } catch { }
                    ReleaseCom(doc);
                }
                if (wordApp != null)
                {
                    try { wordApp.Quit(); } catch { }
                    ReleaseCom(wordApp);
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void GenerateCatalogDocument(string templatePath = null)
        {
            var products = _dbContext.Products.Include(p => p.Material).ToList();
            if (products.Count == 0)
            {
                MessageBox.Show("Нет изделий для формирования каталога.");
                return;
            }

            Word.Application app = null;
            Word.Document doc = null;

            try
            {
                app = CreateWordApp(false);
                doc = app.Documents.Add();

                // Заголовок
                Word.Paragraph header = doc.Content.Paragraphs.Add();
                header.Range.Text = "КАТАЛОГ ИЗДЕЛИЙ";
                header.Range.Font.Size = 16;
                header.Range.Font.Bold = 1;
                header.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                header.Range.InsertParagraphAfter();

                // Информация о предприятии (пусть пользователь вручную впишет потом)
                Word.Paragraph info = doc.Content.Paragraphs.Add();
                info.Range.Text = "Наименование предприятия: ___________________________\n" +
                                  "Адрес: ______________________________________________\n" +
                                  "Телефон: ____________________________________________\n";
                info.Range.Font.Size = 12;
                info.Range.Font.Bold = 0;
                info.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                info.Range.InsertParagraphAfter();

                // Немного отступа
                doc.Content.Paragraphs.Add();
                doc.Content.Paragraphs.Last.Range.InsertParagraphAfter();

                // Таблица каталога
                int rows = products.Count + 1;
                int cols = 5;
                Word.Table table = doc.Tables.Add(doc.Content.Paragraphs.Last.Range, rows, cols);
                table.Borders.Enable = 1;
                table.Range.Font.Size = 11;

                var headers = new[] { "№", "Название", "Тип", "Материал", "Цена (₽)" };
                for (int i = 0; i < cols; i++)
                {
                    table.Cell(1, i + 1).Range.Text = headers[i];
                    table.Cell(1, i + 1).Range.Bold = 1;
                    table.Cell(1, i + 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                int r = 2;
                foreach (var p in products)
                {
                    table.Cell(r, 1).Range.Text = p.Id.ToString();
                    table.Cell(r, 2).Range.Text = p.Name ?? "";
                    table.Cell(r, 3).Range.Text = p.Type ?? "";
                    table.Cell(r, 4).Range.Text = p.Material?.Name ?? "";
                    table.Cell(r, 5).Range.Text = p.Price.ToString("0.00");
                    r++;
                }

                // Немного отступа и подписи
                Word.Paragraph footer = doc.Content.Paragraphs.Add();
                footer.Range.InsertParagraphBefore();
                footer.Range.Text = "\nСоставил: _____________________    Дата: _____________";
                footer.Range.Font.Size = 12;
                footer.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Word Documents|*.docx|Word 97-2003|*.doc";
                    sfd.FileName = "ProductCatalog.docx";
                    sfd.AddExtension = true;
                    sfd.DefaultExt = "docx";
                    sfd.OverwritePrompt = true;

                    var dr = sfd.ShowDialog();
                    if (dr != DialogResult.OK)
                    {
                        // Пользователь отменил — закрываем документ без сохранения
                        try { doc.Close(false); } catch { }
                        return;
                    }

                    var targetPath = sfd.FileName;
                    Word.WdSaveFormat format = Word.WdSaveFormat.wdFormatXMLDocument; // .docx
                    var ext = Path.GetExtension(targetPath)?.ToLowerInvariant();
                    if (ext == ".doc") format = Word.WdSaveFormat.wdFormatDocument;

                    try
                    {
                        doc.SaveAs2(FileName: targetPath, FileFormat: format);
                        MessageBox.Show("Каталог сохранён: " + targetPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не удалось сохранить каталог: " + ex.Message);
                        try { doc.Close(false); } catch { }
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при формировании каталога: " + ex.Message);
            }
            finally
            {
                if (doc != null)
                {
                    doc.Close(false);
                    ReleaseCom(doc);
                }
                if (app != null)
                {
                    app.Quit();
                    ReleaseCom(app);
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }


        private void btnGenerateTable_Click(object sender, EventArgs e)
        {
            // Если хочешь выбирать шаблон через tbTemplateTable — передай путь
            string template = tbTemplateTable.Text.Trim();
            GenerateCombinedTableDocument(template);
        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            // Будем брать Id продажи из tb_saleID (у тебя такой есть)
            if (int.TryParse(tb_saleID.Text, out int saleId))
            {
                string template = tbTemplateInvoice.Text.Trim();
                GenerateInvoiceForSale(saleId, template);
            }
            else
            {
                MessageBox.Show("Укажи корректный Id продажи в tb_saleID.");
            }
        }

        private void btnGenerateCatalog_Click(object sender, EventArgs e)
        {
            string template = tbTemplateTable.Text.Trim();
            GenerateCatalogDocument(template);
        }
        private void btnChooseTemplateInvoice_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Word Documents|*.docx";
                if (ofd.ShowDialog() == DialogResult.OK) tbTemplateInvoice.Text = ofd.FileName;
            }
        }

        private void btnChooseTemplateTable_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Word Documents|*.docx";
                if (ofd.ShowDialog() == DialogResult.OK) tbTemplateTable.Text = ofd.FileName;
            }
        }
        private void btnExportReport1_Click(object sender, EventArgs e)
        {
            ExportReport_AllSalesWithProductAndMaterial();
        }
        //АААААААААААААААААА Эксель
        private void ExportReport_AllSalesWithProductAndMaterial()
        {
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet sheet = null;
            try
            {
                excelApp = new Excel.Application();
                workbook = excelApp.Workbooks.Add();
                sheet = (Excel.Worksheet)workbook.Worksheets[1];
                sheet.Name = "SalesFull";

                // Заголовки
                string[] headers = new string[]
                {
            "SaleId","SaleDate","LastName","FirstName","MiddleName",
            "ProductId","ProductName","ProductType","ProductWeight","ProductPrice",
            "MaterialId","MaterialName","MaterialPricePerGram"
                };
                for (int i = 0; i < headers.Length; i++)
                {
                    sheet.Cells[1, i + 1] = headers[i];
                }

                // Формат заголовка: жирный, фон
                Excel.Range headerRange = sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, headers.Length]];
                headerRange.Font.Bold = true;
                headerRange.Interior.Pattern = Excel.XlPattern.xlPatternSolid;
                headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                headerRange.Borders.Weight = Excel.XlBorderWeight.xlThin;

                // Данные
                var sales = _dbContext.Sales.Include(s => s.Product).ThenInclude(p => p.Material).ToList();
                int row = 2;
                foreach (var s in sales)
                {
                    var p = s.Product;
                    var m = p?.Material;
                    sheet.Cells[row, 1] = s.Id;
                    sheet.Cells[row, 2] = s.SaleDate.ToString("yyyy-MM-dd");
                    sheet.Cells[row, 3] = s.LastName;
                    sheet.Cells[row, 4] = s.FirstName;
                    sheet.Cells[row, 5] = s.MiddleName ?? "";
                    sheet.Cells[row, 6] = p?.Id ?? 0;
                    sheet.Cells[row, 7] = p?.Name ?? "";
                    sheet.Cells[row, 8] = p?.Type ?? "";
                    sheet.Cells[row, 9] = p?.Weight ?? 0;
                    sheet.Cells[row, 10] = p?.Price ?? 0;
                    sheet.Cells[row, 11] = m?.Id ?? 0;
                    sheet.Cells[row, 12] = m?.Name ?? "";
                    sheet.Cells[row, 13] = m?.PricePerGram ?? 0;
                    row++;
                }

                // Форматирование колонок
                sheet.Columns.AutoFit();
                // Цена колонка (ProductPrice) — кол-во столбца 10 (J)
                Excel.Range priceRange = sheet.Range["J2", $"J{row - 1}"];
                priceRange.NumberFormat = "#,##0.00";
                Marshal.ReleaseComObject(priceRange);

                // Дата (B)
                Excel.Range dateRange = sheet.Range["B2", $"B{row - 1}"];
                dateRange.NumberFormat = "yyyy-mm-dd";
                Marshal.ReleaseComObject(dateRange);

                // Сохранение
                sfdExcel.Filter = "Excel Workbook|*.xlsx";
                sfdExcel.FileName = "SalesFull.xlsx";
                if (sfdExcel.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfdExcel.FileName);
                    MessageBox.Show("Отчёт сохранён: " + sfdExcel.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка экспорта: " + ex.Message);
            }
            finally
            {
                if (workbook != null) workbook.Close(false);
                if (excelApp != null) excelApp.Quit();
                if (sheet != null) Marshal.ReleaseComObject(sheet);
                if (workbook != null) Marshal.ReleaseComObject(workbook);
                if (excelApp != null) Marshal.ReleaseComObject(excelApp);
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }



        private void btnExportReport2_Click(object sender, EventArgs e)
        {
            ExportReport_ProductsSummary();
        }

        private void ExportReport_ProductsSummary()
        {
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet sheet = null;

            try
            {
                excelApp = new Excel.Application();
                workbook = excelApp.Workbooks.Add();
                sheet = (Excel.Worksheet)workbook.Worksheets[1];
                sheet.Name = "ProductsSummary";

                // Заголовки
                string[] headers = new string[]
                {
            "ProductId","ProductName","Type","MaterialName",
            "Weight","Price","SalesCount","TotalRevenue"
                };

                for (int i = 0; i < headers.Length; i++)
                    sheet.Cells[1, i + 1] = headers[i];

                // Получаем все продукты и связанные материалы
                var products = _dbContext.Products
                    .Include(p => p.Material)
                    .ToList();

                int row = 2;

                foreach (var p in products)
                {
                    // Подсчёт количества продаж по продукту
                    int salesCount = _dbContext.Sales.Count(s => s.ProductId == p.Id);

                    // Общая выручка = цена * количество продаж
                    decimal totalRevenue = p.Price * salesCount;

                    sheet.Cells[row, 1] = p.Id;
                    sheet.Cells[row, 2] = p.Name;
                    sheet.Cells[row, 3] = p.Type;
                    sheet.Cells[row, 4] = p.Material?.Name ?? "";
                    sheet.Cells[row, 5] = p.Weight;
                    sheet.Cells[row, 6] = (double)p.Price;
                    sheet.Cells[row, 7] = salesCount;
                    sheet.Cells[row, 8] = (double)totalRevenue;

                    row++;
                }

                // Оформление шапки
                Excel.Range headerRange = sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, headers.Length]];
                headerRange.Font.Bold = true;
                headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightSteelBlue);
                headerRange.Borders.Weight = Excel.XlBorderWeight.xlThin;
                headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                // Форматирование числовых колонок
                sheet.Columns.AutoFit();

                Excel.Range priceRange = sheet.Range["F2", $"F{row - 1}"];
                priceRange.NumberFormat = "#,##0.00";
                Marshal.ReleaseComObject(priceRange);

                Excel.Range revenueRange = sheet.Range["H2", $"H{row - 1}"];
                revenueRange.NumberFormat = "#,##0.00";
                Marshal.ReleaseComObject(revenueRange);

                // Сохранение
                sfdExcel.Filter = "Excel Workbook|*.xlsx";
                sfdExcel.FileName = "ProductsSummary.xlsx";
                if (sfdExcel.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfdExcel.FileName);
                    MessageBox.Show("Отчёт сохранён: " + sfdExcel.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка экспорта: " + ex.Message);
            }
            finally
            {
                if (workbook != null) workbook.Close(false);
                if (excelApp != null) excelApp.Quit();
                if (sheet != null) Marshal.ReleaseComObject(sheet);
                if (workbook != null) Marshal.ReleaseComObject(workbook);
                if (excelApp != null) Marshal.ReleaseComObject(excelApp);
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            if (ofdExcel.ShowDialog() != DialogResult.OK) return;
            string path = ofdExcel.FileName;
            ImportFromExcel(path);
        }

        private void ImportFromExcel(string path)
        {
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;

            try
            {
                excelApp = new Excel.Application();
                workbook = excelApp.Workbooks.Open(path);

                // ---------- 1) Materials ----------
                Excel.Worksheet matSheet = null;
                try { matSheet = workbook.Worksheets["Materials"]; } catch { matSheet = null; }
                if (matSheet != null)
                {
                    int row = 2;
                    while (true)
                    {
                        var cellName = (matSheet.Cells[row, 2] as Excel.Range)?.Value2;
                        if (cellName == null) break;

                        string name = cellName.ToString().Trim();
                        var cellPrice = (matSheet.Cells[row, 3] as Excel.Range)?.Value2;

                        int price = 0;
                        if (cellPrice != null)
                        {
                            if (!int.TryParse(cellPrice.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out price))
                            {
                                try { price = Convert.ToInt32(cellPrice); } catch { price = 0; }
                            }
                        }

                        var existing = _dbContext.Materials.FirstOrDefault(m => m.Name.ToLower() == name.ToLower());
                        if (existing == null)
                            _dbContext.Materials.Add(new Material { Name = name, PricePerGram = price });
                        else
                        {
                            existing.PricePerGram = price;
                            _dbContext.Materials.Update(existing);
                        }

                        row++;
                    }
                    _dbContext.SaveChanges();
                    ReleaseComObjectSafe(matSheet);
                }

                // ---------- 2) Products ----------
                Excel.Worksheet prodSheet = null;
                try { prodSheet = workbook.Worksheets["Products"]; } catch { prodSheet = null; }
                if (prodSheet != null)
                {
                    int row = 2;
                    while (true)
                    {
                        var cellName = (prodSheet.Cells[row, 2] as Excel.Range)?.Value2;
                        if (cellName == null) break;

                        string name = cellName.ToString().Trim();
                        string type = (prodSheet.Cells[row, 3] as Excel.Range)?.Value2?.ToString() ?? "";
                        string materialName = (prodSheet.Cells[row, 4] as Excel.Range)?.Value2?.ToString().Trim() ?? "";

                        double weight = 0;
                        var cellWeight = (prodSheet.Cells[row, 5] as Excel.Range)?.Value2;
                        if (cellWeight != null)
                        {
                            if (!double.TryParse(cellWeight.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out weight))
                            {
                                try { weight = Convert.ToDouble(cellWeight); } catch { weight = 0; }
                            }
                        }

                        decimal price = 0;
                        var cellPrice = (prodSheet.Cells[row, 6] as Excel.Range)?.Value2;
                        if (cellPrice != null)
                        {
                            if (!decimal.TryParse(cellPrice.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out price))
                            {
                                try { price = Convert.ToDecimal(cellPrice); } catch { price = 0; }
                            }
                        }

                        Material mat = null;
                        if (!string.IsNullOrWhiteSpace(materialName))
                        {
                            mat = _dbContext.Materials.FirstOrDefault(m => m.Name.ToLower() == materialName.ToLower());
                            if (mat == null)
                            {
                                mat = new Material { Name = materialName, PricePerGram = 0 };
                                _dbContext.Materials.Add(mat);
                                _dbContext.SaveChanges();
                            }
                        }

                        var existingProd = _dbContext.Products.FirstOrDefault(p =>
                            p.Name.ToLower() == name.ToLower() && p.Type.ToLower() == type.ToLower());

                        if (existingProd == null)
                        {
                            _dbContext.Products.Add(new Product
                            {
                                Name = name,
                                Type = type,
                                MaterialId = mat?.Id ?? 0,
                                Weight = weight,
                                Price = price
                            });
                        }
                        else
                        {
                            existingProd.MaterialId = mat?.Id ?? existingProd.MaterialId;
                            existingProd.Weight = weight;
                            existingProd.Price = price;
                            _dbContext.Products.Update(existingProd);
                        }

                        row++;
                    }
                    _dbContext.SaveChanges();
                    ReleaseComObjectSafe(prodSheet);
                }

                // ---------- 3) Sales ----------
                Excel.Worksheet salesSheet = null;
                try { salesSheet = workbook.Worksheets["Sales"]; } catch { salesSheet = null; }
                List<string> missingProducts = new List<string>();

                if (salesSheet != null)
                {
                    int row = 2;

                    var productsByName = _dbContext.Products
                        .AsNoTracking()
                        .ToList()
                        .GroupBy(p => p.Name.ToLower())
                        .ToDictionary(g => g.Key, g => g.First());

                    while (true)
                    {
                        var cellDate = (salesSheet.Cells[row, 2] as Excel.Range)?.Value2;
                        var cellLast = (salesSheet.Cells[row, 3] as Excel.Range)?.Value2;
                        var cellFirst = (salesSheet.Cells[row, 4] as Excel.Range)?.Value2;
                        var cellMiddle = (salesSheet.Cells[row, 5] as Excel.Range)?.Value2;
                        var cellProductName = (salesSheet.Cells[row, 6] as Excel.Range)?.Value2;

                        if (cellProductName == null && cellLast == null && cellFirst == null && cellDate == null)
                            break;

                        // === Корректное преобразование даты ===
                        DateTime saleDate = DateTime.MinValue;
                        if (cellDate != null)
                        {
                            if (cellDate is double d)
                                saleDate = DateTime.FromOADate(d);
                            else if (DateTime.TryParse(cellDate.ToString(), out DateTime dt))
                                saleDate = dt;
                        }

                        if (saleDate != DateTime.MinValue)
                        {
                            // Устанавливаем Kind = Utc для PostgreSQL
                            saleDate = DateTime.SpecifyKind(saleDate, DateTimeKind.Utc);
                        }

                        string last = cellLast?.ToString()?.Trim() ?? "";
                        string first = cellFirst?.ToString()?.Trim() ?? "";
                        string middle = cellMiddle?.ToString()?.Trim() ?? "";
                        string productName = cellProductName?.ToString()?.Trim() ?? "";

                        if (string.IsNullOrWhiteSpace(productName))
                        {
                            missingProducts.Add("(пустое имя продукта)");
                            row++;
                            continue;
                        }

                        productsByName.TryGetValue(productName.ToLower(), out Product prod);
                        if (prod == null)
                        {
                            /* missingProducts.Add(productName);
                             row++;
                             continue;*/

                            prod = new Product
                            {
                                Id = _dbContext.Products
                                    .OrderBy(p => p.Id)
                                    .Last().Id + 1,

                                Name = productName,
                                Type = "",
                                MaterialId = _dbContext.Materials.First().Id,
                            };

                            _dbContext.Products.Add(prod);
                            _dbContext.SaveChanges();
                        }

                        _dbContext.Sales.Add(new Sale
                        {
                            SaleDate = saleDate,
                            LastName = last,
                            FirstName = first,
                            MiddleName = middle,
                            ProductId = prod.Id
                        });

                        row++;
                    }

                    _dbContext.SaveChanges();
                    ReleaseComObjectSafe(salesSheet);
                }

                if (missingProducts.Count > 0)
                {
                    string uniq = string.Join(", ", missingProducts.Distinct());
                    MessageBox.Show("Некоторые продажи пропущены — не найден продукт(ы): " + uniq);
                }
                else
                {
                    MessageBox.Show("Импорт завершён успешно.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка импорта: " + (ex.InnerException?.Message ?? ex.Message));
            }
            finally
            {
                try
                {
                    workbook?.Close(false);
                    excelApp?.Quit();
                }
                catch { }

                ReleaseComObjectSafe(workbook);
                ReleaseComObjectSafe(excelApp);

                GC.Collect();
                GC.WaitForPendingFinalizers();

                _dbContext.Materials.Load();
                materialDataView.DataSource = _dbContext.Materials.Local.ToBindingList();
                _dbContext.Products.Load();
                productDataView.DataSource = _dbContext.Products.Local.ToBindingList();
                _dbContext.Sales.Load();
                saleDataView.DataSource = _dbContext.Sales.Local.ToBindingList();
            }
        }

        private string HtmlEncode(string text)
        {
            if (string.IsNullOrEmpty(text)) return string.Empty;
            return System.Net.WebUtility.HtmlEncode(text);
        }
        private void GenerateHtmlCombinedReport_GroupByMaterial()
        {
            try
            {
                // Загружаем данные корректно:
                var materials = _dbContext.Materials
                    .AsNoTracking()
                    .OrderBy(m => m.Name)
                    .ToList();

                var products = _dbContext.Products
                    .Include(p => p.Material) // каждый продукт вместе с материалом
                    .AsNoTracking()
                    .ToList();

                var sales = _dbContext.Sales
                    .Include(s => s.Product)
                        .ThenInclude(p => p.Material) // продажи с продуктом и материалом
                    .AsNoTracking()
                    .ToList();

                if (!materials.Any() && !products.Any() && !sales.Any())
                {
                    MessageBox.Show("Нет данных для формирования отчёта.");
                    return;
                }

                var sb = new StringBuilder();
                sb.AppendLine("<!doctype html>");
                sb.AppendLine("<html lang=\"ru\">");
                sb.AppendLine("<head>");
                sb.AppendLine("<meta charset=\"utf-8\" />");
                sb.AppendLine("<title>Отчёт — Продажи и изделия</title>");
                sb.AppendLine("<style>");
                sb.AppendLine("body{font-family:Segoe UI, Tahoma, Arial, sans-serif; margin:20px; color:#222}");
                sb.AppendLine("h1{font-size:20px; margin-bottom:6px}");
                sb.AppendLine(".material{margin-top:24px; padding:12px; border:1px solid #ddd; border-radius:6px; background:#fafafa}");
                sb.AppendLine(".material h2{margin:0 0 8px 0; font-size:16px}");
                sb.AppendLine("table{border-collapse:collapse; width:100%; margin-bottom:8px}");
                sb.AppendLine("th,td{border:1px solid #ccc; padding:6px; text-align:left; font-size:13px}");
                sb.AppendLine("th{background:#efefef}");
                sb.AppendLine(".small{font-size:12px; color:#555}");
                sb.AppendLine("a.link{color:#0066cc; text-decoration:none}");
                sb.AppendLine("</style>");
                sb.AppendLine("</head>");
                sb.AppendLine("<body>");
                sb.AppendLine("<h1>Отчёт: Продажи и изделия (группировка по материалу)</h1>");
                sb.AppendLine($"<div class=\"small\">Сформировано: {DateTime.Now:yyyy-MM-dd HH:mm}</div>");
                sb.AppendLine("<hr/>");

                // Если нет материалов, но есть продукты/продажи - покажем "Без материала"
                var materialsOrdered = materials.Any() ? materials : new List<JewelryWorkshop.Data.Material>
        {
            new JewelryWorkshop.Data.Material { Id = 0, Name = "Без материала" }
        };

                foreach (var mat in materialsOrdered)
                {
                    sb.AppendLine("<div class=\"material\">");
                    sb.AppendLine($"<h2>Материал: {HtmlEncode(mat.Name)} (Id: {mat.Id})</h2>");

                    // Продукты этого материала
                    var prodsOfMat = products
                        .Where(p => (p.MaterialId == mat.Id) || (p.Material != null && p.Material.Id == mat.Id))
                        .OrderBy(p => p.Name)
                        .ToList();

                    sb.AppendLine("<h3>Изделия</h3>");
                    if (!prodsOfMat.Any())
                    {
                        sb.AppendLine("<div class=\"small\">Нет изделий для этого материала.</div>");
                    }
                    else
                    {
                        sb.AppendLine("<table>");
                        sb.AppendLine("<thead><tr><th>Id</th><th>Название</th><th>Тип</th><th>Вес (г)</th><th>Цена</th><th>Продажи (кол-во)</th></tr></thead>");
                        sb.AppendLine("<tbody>");
                        foreach (var p in prodsOfMat)
                        {
                            var salesForProduct = sales.Where(s => s.ProductId == p.Id).ToList();
                            var salesCount = salesForProduct.Count;
                            var anchor = $"prod_{p.Id}";

                            sb.AppendLine("<tr>");
                            sb.AppendLine($"<td>{p.Id}</td>");
                            sb.AppendLine($"<td><a class=\"link\" href=\"#{anchor}\">{HtmlEncode(p.Name)}</a></td>");
                            sb.AppendLine($"<td>{HtmlEncode(p.Type)}</td>");
                            sb.AppendLine($"<td>{p.Weight:0.##}</td>");
                            sb.AppendLine($"<td>{p.Price:0.00}</td>");
                            sb.AppendLine($"<td>{salesCount}</td>");
                            sb.AppendLine("</tr>");
                        }
                        sb.AppendLine("</tbody></table>");
                    }

                    // Продажи по материалу
                    sb.AppendLine("<h3>Продажи по материалу</h3>");
                    var salesForMaterial = sales
                        .Where(s => s.Product != null && ((s.Product.MaterialId == mat.Id) || (s.Product.Material != null && s.Product.Material.Id == mat.Id)))
                        .OrderBy(s => s.SaleDate)
                        .ToList();

                    if (!salesForMaterial.Any())
                    {
                        sb.AppendLine("<div class=\"small\">Нет продаж для изделий этого материала.</div>");
                    }
                    else
                    {
                        sb.AppendLine("<table>");
                        sb.AppendLine("<thead><tr><th>SaleId</th><th>Дата</th><th>Покупатель</th><th>Изделие (Id)</th><th>Материал</th></tr></thead>");
                        sb.AppendLine("<tbody>");
                        foreach (var s in salesForMaterial)
                        {
                            var prod = s.Product;
                            var prodLink = prod != null ? $"<a class=\"link\" href=\"#prod_{prod.Id}\">{HtmlEncode(prod.Name)}</a>" : "—";
                            var matName = prod?.Material?.Name ?? HtmlEncode(mat.Name) ?? "";
                            sb.AppendLine("<tr>");
                            sb.AppendLine($"<td>{s.Id}</td>");
                            sb.AppendLine($"<td>{(s.SaleDate == default ? "" : s.SaleDate.ToString("yyyy-MM-dd HH:mm"))}</td>");
                            sb.AppendLine($"<td>{HtmlEncode($"{s.LastName} {s.FirstName} {s.MiddleName}")}</td>");
                            sb.AppendLine($"<td>{prodLink} ({prod?.Id.ToString() ?? "-"})</td>");
                            sb.AppendLine($"<td>{HtmlEncode(matName)}</td>");
                            sb.AppendLine("</tr>");
                        }
                        sb.AppendLine("</tbody></table>");
                    }

                    sb.AppendLine("</div>"); // .material
                }

                // Продажи без связанного материала/изделия
                var salesWithoutMaterial = sales.Where(s => s.Product == null || s.Product.Material == null).ToList();
                if (salesWithoutMaterial.Any())
                {
                    sb.AppendLine("<div style=\"margin-top:20px;border-top:1px dashed #ddd;padding-top:10px;\">");
                    sb.AppendLine("<h2>Продажи без связанного материала/изделия</h2>");
                    sb.AppendLine("<table>");
                    sb.AppendLine("<thead><tr><th>SaleId</th><th>Дата</th><th>Покупатель</th><th>ProductId</th></tr></thead><tbody>");
                    foreach (var s in salesWithoutMaterial)
                    {
                        sb.AppendLine("<tr>");
                        sb.AppendLine($"<td>{s.Id}</td>");
                        sb.AppendLine($"<td>{(s.SaleDate == default ? "" : s.SaleDate.ToString("yyyy-MM-dd HH:mm"))}</td>");
                        sb.AppendLine($"<td>{HtmlEncode($"{s.LastName} {s.FirstName} {s.MiddleName}")}</td>");
                        sb.AppendLine($"<td>{s.ProductId}</td>");
                        sb.AppendLine("</tr>");
                    }
                    sb.AppendLine("</tbody></table>");
                    sb.AppendLine("</div>");
                }

                sb.AppendLine("</body></html>");

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "HTML files|*.html;*.htm";
                    sfd.FileName = "SalesMaterialReport.html";
                    if (sfd.ShowDialog() != DialogResult.OK)
                    {
                        MessageBox.Show("Сохранение отменено.");
                        return;
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Отчёт сохранён: " + sfd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при формировании HTML-отчёта: " + ex.Message);
            }
        }


        private void GenerateHtmlCatalogReport()
        {
            try
            {
                var products = _dbContext.Products.Include(p => p.Material).OrderBy(p => p.Name).ToList();
                if (!products.Any())
                {
                    MessageBox.Show("Нет изделий для формирования каталога.");
                    return;
                }

                var sb = new StringBuilder();
                sb.AppendLine("<!doctype html>");
                sb.AppendLine("<html lang=\"ru\"><head><meta charset=\"utf-8\"/>");
                sb.AppendLine("<title>Каталог изделий</title>");
                sb.AppendLine("<style>");
                sb.AppendLine("body{font-family:Segoe UI, Tahoma, Arial; margin:20px; color:#222}");
                sb.AppendLine("h1{font-size:18px}");
                sb.AppendLine("table{border-collapse:collapse; width:100%}");
                sb.AppendLine("th,td{border:1px solid #ccc; padding:6px}");
                sb.AppendLine("th{background:#efefef}");
                sb.AppendLine("</style></head><body>");
                sb.AppendLine("<h1>Каталог изделий</h1>");
                sb.AppendLine($"<div class=\"small\">Сформировано: {DateTime.Now:yyyy-MM-dd HH:mm}</div>");
                sb.AppendLine("<table>");
                sb.AppendLine("<thead><tr><th>Id</th><th>Название</th><th>Тип</th><th>Материал</th><th>Вес (г)</th><th>Цена</th></tr></thead>");
                sb.AppendLine("<tbody>");
                foreach (var p in products)
                {
                    sb.AppendLine("<tr>");
                    sb.AppendLine($"<td>{p.Id}</td>");
                    sb.AppendLine($"<td>{HtmlEncode(p.Name)}</td>");
                    sb.AppendLine($"<td>{HtmlEncode(p.Type)}</td>");
                    sb.AppendLine($"<td>{HtmlEncode(p.Material?.Name)}</td>");
                    sb.AppendLine($"<td>{p.Weight:0.##}</td>");
                    sb.AppendLine($"<td>{p.Price:0.00}</td>");
                    sb.AppendLine("</tr>");
                }
                sb.AppendLine("</tbody></table>");
                sb.AppendLine("</body></html>");

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "HTML files|*.html;*.htm";
                    sfd.FileName = "Catalog.html";
                    if (sfd.ShowDialog() != DialogResult.OK)
                    {
                        MessageBox.Show("Сохранение отменено.");
                        return;
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Каталог сохранён: " + sfd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при формировании HTML-каталога: " + ex.Message);
            }
        }











        private void saleDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_Material_TextChanged(object sender, EventArgs e)
        {

        }


        private void tb_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_saleDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_filterMaterial_TextChanged(object sender, EventArgs e)
        {

        }
        private void ReleaseComObjectSafe(object comObj)
        {
            try
            {
                if (comObj != null && Marshal.IsComObject(comObj))
                {
                    Marshal.ReleaseComObject(comObj);
                }
            }
            catch
            {
                // Игнорируем возможные ошибки — Excel может уже сам освободить объект
            }
            finally
            {
                comObj = null;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}


//if (tb_ID.Text == String.Empty) return;
//int id = Convert.ToInt32(tb_ID.Text);
//Material material = _dbContext.Materials.Find(id);
//if (material == null) return;
//material.Name = tb_Material.Text;