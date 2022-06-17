namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown3 = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.domainUpDown4 = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.domainUpDown5 = new System.Windows.Forms.DomainUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.SaveFileDialog();
            this.open = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.domainUpDown6 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown7 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown8 = new System.Windows.Forms.DomainUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.BackColor = System.Drawing.SystemColors.Control;
            this.domainUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.domainUpDown1.Location = new System.Drawing.Point(108, 7);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.ReadOnly = true;
            this.domainUpDown1.Size = new System.Drawing.Size(200, 20);
            this.domainUpDown1.TabIndex = 0;
            this.domainUpDown1.Text = "Технології програмування";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Назва предмету";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Location = new System.Drawing.Point(335, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Навчальний рік";
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.BackColor = System.Drawing.SystemColors.Control;
            this.domainUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.domainUpDown2.Location = new System.Drawing.Point(426, 12);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.ReadOnly = true;
            this.domainUpDown2.Size = new System.Drawing.Size(76, 20);
            this.domainUpDown2.TabIndex = 0;
            this.domainUpDown2.Text = "2021-2022";
            this.domainUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.domainUpDown2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.domainUpDown2_KeyPress);
            // 
            // domainUpDown3
            // 
            this.domainUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.domainUpDown3.Location = new System.Drawing.Point(108, 33);
            this.domainUpDown3.Name = "domainUpDown3";
            this.domainUpDown3.ReadOnly = true;
            this.domainUpDown3.Size = new System.Drawing.Size(200, 20);
            this.domainUpDown3.TabIndex = 0;
            this.domainUpDown3.Text = "123 - Компьютерна інженерія";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Спеціальність";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Location = new System.Drawing.Point(12, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Затверджено на засіданні";
            // 
            // domainUpDown4
            // 
            this.domainUpDown4.BackColor = System.Drawing.SystemColors.Control;
            this.domainUpDown4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.domainUpDown4.Items.Add("Кафедри комп’ютерних систем, мереж та кібербезпеки (503) ");
            this.domainUpDown4.Location = new System.Drawing.Point(157, 67);
            this.domainUpDown4.Name = "domainUpDown4";
            this.domainUpDown4.ReadOnly = true;
            this.domainUpDown4.Size = new System.Drawing.Size(345, 20);
            this.domainUpDown4.TabIndex = 0;
            this.domainUpDown4.Text = "Кафедри комп’ютерних систем, мереж та кібербезпеки (503) ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Location = new System.Drawing.Point(13, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Протокол";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.SystemColors.Control;
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numericUpDown2.Location = new System.Drawing.Point(75, 101);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Location = new System.Drawing.Point(131, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "від";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.SystemColors.Control;
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numericUpDown3.Location = new System.Drawing.Point(157, 101);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown3.TabIndex = 1;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.BackColor = System.Drawing.SystemColors.Control;
            this.numericUpDown4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numericUpDown4.Location = new System.Drawing.Point(227, 101);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown4.TabIndex = 1;
            this.numericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(168, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 14);
            this.label8.TabIndex = 2;
            this.label8.Text = "день";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(236, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 14);
            this.label9.TabIndex = 2;
            this.label9.Text = "місяць";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(93, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 14);
            this.label10.TabIndex = 2;
            this.label10.Text = "№";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Location = new System.Drawing.Point(343, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Викладач";
            // 
            // domainUpDown5
            // 
            this.domainUpDown5.BackColor = System.Drawing.SystemColors.Control;
            this.domainUpDown5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.domainUpDown5.Items.Add("Дужа В.В.");
            this.domainUpDown5.Location = new System.Drawing.Point(404, 41);
            this.domainUpDown5.Name = "domainUpDown5";
            this.domainUpDown5.Size = new System.Drawing.Size(98, 20);
            this.domainUpDown5.TabIndex = 0;
            this.domainUpDown5.Text = "Дужа В.В.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сформувати білет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // open
            // 
            this.open.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(478, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 20);
            this.button2.TabIndex = 5;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // domainUpDown6
            // 
            this.domainUpDown6.BackColor = System.Drawing.SystemColors.Control;
            this.domainUpDown6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.domainUpDown6.Items.Add("Функции и назначение ОС. Требования к ОС. Функции ОС. Состав ОС (Основные подсист" +
        "емы ОС). Понятие \"ресурса\" (активы) компьютера.");
            this.domainUpDown6.Items.Add("Функции и назначение ОС. Иерархическая структура ОС. Платформа.Типы инфраструктур" +
        ": IaaS, PaaS, SaaS.");
            this.domainUpDown6.Items.Add("Ресурс \"Процессор\". Режимы работы процессора. Программно доступные регистры. Поль" +
        "зовательские регистры. Системные регистры.");
            this.domainUpDown6.Items.Add("Ресурс \"память\". Логические и физические адреса. Защита памяти.");
            this.domainUpDown6.Items.Add("Ресурс \"ввод–вывод\". Проблемы организации ввода–вывода. Команды ввода–вывода. Пор" +
        "ты. Драйвер ввода–вывода.");
            this.domainUpDown6.Items.Add("Ресурс \"ввод–вывод\". Проблемы организации ввода–вывода. Ввод–вывод, отображенный " +
        "на память. Драйвер ввода–вывода.");
            this.domainUpDown6.Items.Add("Прерывания процессора. Виды прерываний. Программные прерывания.");
            this.domainUpDown6.Items.Add("Исключения. Зарезервированные исключения.");
            this.domainUpDown6.Items.Add("Прерывания процессора. Виды прерываний. Аппаратные прерывания.");
            this.domainUpDown6.Items.Add("Прерывания процессора. Множественные прерывания. Приоритеты устройств. Виды тайме" +
        "ров.");
            this.domainUpDown6.Items.Add("Эволюция ОС. Поколения ОС. Последовательные машины.");
            this.domainUpDown6.Items.Add("Пакетные системы. Структура ОС. Монитор. Язык обработки заданий. Технические реше" +
        "ния.");
            this.domainUpDown6.Items.Add("Многозадачные пакетные системы. Структура ОС. Технические решения.");
            this.domainUpDown6.Items.Add("Интерактивные системы. ОС реального времени. Технические решения.");
            this.domainUpDown6.Items.Add("Современные ОС. Мобильные вычисления. Облачные вычисления. Типы инфраструктур: Ia" +
        "aS, PaaS, SaaS.");
            this.domainUpDown6.Items.Add("Технические средства ОС. Ресурс \"Процессор\". Регистры. Флаги. Уровни защиты. Сегм" +
        "ент состояния задачи. Поток.");
            this.domainUpDown6.Items.Add("Технические средства ОС. Ресурс \"Память\". Логический адрес. Физический адрес. Вир" +
        "туальная память. Многоуровневая организация памяти.");
            this.domainUpDown6.Items.Add("Технические средства ОС. Ресурс \"Ввод–вывод\". Состав периферийногоустройства. Спо" +
        "собы подключения периферийного устройства к процессору.");
            this.domainUpDown6.Items.Add("Технические средства ОС. Ресурс \"Ввод–вывод\". Состав периферийного устройства. ");
            this.domainUpDown6.Items.Add("Архитектура ОС. Виды системных архитектур программы. Понятие ядра. Монолитное ядр" +
        "о. Достоинства и недостатки.");
            this.domainUpDown6.Items.Add("Архитектура ОС. Виды системных архитектур программы. Понятие ядра. Микроядро. Дос" +
        "тоинства и недостатки.");
            this.domainUpDown6.Items.Add("Архитектура ОС. Виды системных архитектур программы. Понятие ядра.Ядро на основе " +
        "Framework. Достоинства и недостатки.");
            this.domainUpDown6.Items.Add("Ресурсы ОС. Понятие процесса, потока. Операции с процессами.");
            this.domainUpDown6.Items.Add("Понятие состояния процесса. Модель ОС с 5-ю состояниями процессов.");
            this.domainUpDown6.Items.Add("Понятие состояния процесса. Модель ОС с 6-ю состояниями процессов.");
            this.domainUpDown6.Items.Add("Ресурсы ОС. Описание процессов. Системные таблицы для работы с процессами.");
            this.domainUpDown6.Items.Add("Атрибуты процессов. PCB. Структуры данных, используемые диспетчером процессов. Об" +
        "раз процесса.");
            this.domainUpDown6.Items.Add("Цель планирования. Виды планирования. Задачи долгосрочного планиро-вания. Критери" +
        "и планирования.");
            this.domainUpDown6.Items.Add("Цель планирования. Виды планирования. Задачи среднесрочного планиро-вания. Критер" +
        "ии планирования.");
            this.domainUpDown6.Items.Add("Цель планирования. Виды планирования. Задачи краткосрочного планиро-вания. Критер" +
        "ии планирования.");
            this.domainUpDown6.Items.Add("Виды стратегий. Приоритет процессов. Параметры стратегии.");
            this.domainUpDown6.Items.Add("Стратегия FCFS. Характеристики. Достоинства и недостатки.");
            this.domainUpDown6.Items.Add("Стратегия SPN. Характеристики. Достоинства и недостатки.");
            this.domainUpDown6.Items.Add("Стратегия HRRN. Характеристики. Достоинства и недостатки.");
            this.domainUpDown6.Items.Add("Стратегия RR. Характеристики. Достоинства и недостатки.");
            this.domainUpDown6.Items.Add("Стратегия SRT. Характеристики. Достоинства и недостатки.");
            this.domainUpDown6.Items.Add("Многоуровневая стратегия со снижением приоритетов. Характеристики.Достоинства и н" +
        "едостатки.");
            this.domainUpDown6.Items.Add("Стратегия \"справедливое плинирование\". Формула. Характеристики. Достоинства и нед" +
        "остатки.");
            this.domainUpDown6.Items.Add("Управление памятью. Требования к управлению памятью. Многоуровневая организация п" +
        "амяти.");
            this.domainUpDown6.Items.Add("Задачи диспетчера памяти. Виды распределения памяти. Простые способы распределени" +
        "я памяти. ");
            this.domainUpDown6.Items.Add("Задачи диспетчера памяти. Виды распределения памяти. Простые способы распределени" +
        "я памяти.");
            this.domainUpDown6.Items.Add("Виды распределения памяти. Простые способы распределения памяти. Достоинства и не" +
        "достатки.");
            this.domainUpDown6.Items.Add("Виды распределения памяти. Простые способы распределения памяти. Динамическое рас" +
        "пределение памяти. Достоинства и недостатки.");
            this.domainUpDown6.Items.Add("Понятие фрагментации памяти в системах с динамическим распределением. ");
            this.domainUpDown6.Items.Add("Простые способы распределения памяти. Алгоритмы выделения памяти процессам в сист" +
        "еме с динамическим распределением памяти. ");
            this.domainUpDown6.Items.Add("Распределение памяти с системой двойников. Достоинства и недостатки.");
            this.domainUpDown6.Items.Add("Страничное распределение памяти. Таблица страниц процесса. Вычисление адреса. Дос" +
        "тоинства и недостатки.");
            this.domainUpDown6.Items.Add("Сегментное распределение памяти. Таблица сегментов процесса. Вычисление адреса. Д" +
        "остоинства и недостатки.");
            this.domainUpDown6.Items.Add("Сегментная организация памяти в реальном режиме МП x86. Схема фор-мирования адрес" +
        "а. ");
            this.domainUpDown6.Items.Add("Понятие виртуальной памяти. Принципы организации. Достоинства и недостатки. Механ" +
        "изм работы. Понятие локализации.");
            this.domainUpDown6.Items.Add("Виртуальная страничная организация памяти. Формат адреса. Таблица страниц процесс" +
        "а. Формат записи.");
            this.domainUpDown6.Location = new System.Drawing.Point(16, 153);
            this.domainUpDown6.Name = "domainUpDown6";
            this.domainUpDown6.ReadOnly = true;
            this.domainUpDown6.Size = new System.Drawing.Size(10, 20);
            this.domainUpDown6.TabIndex = 7;
            this.domainUpDown6.Visible = false;
            // 
            // domainUpDown7
            // 
            this.domainUpDown7.BackColor = System.Drawing.SystemColors.Control;
            this.domainUpDown7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.domainUpDown7.Items.Add("Сущность объектно-ориентированного программирования.");
            this.domainUpDown7.Items.Add("Причины сложности программного обеспечения. Парадигмы программирования и их кратк" +
        "ая характеристика. Определение ООП. Основные принципы ООП. Определение и характе" +
        "ристика класса.");
            this.domainUpDown7.Items.Add("Особенности разработки программ для операционной системы Windows. Событийно-ориен" +
        "тированный подход. ");
            this.domainUpDown7.Items.Add("Характеристика двух основных подходов к разработке программ. Их достоинства и нед" +
        "остатки. Основные категории событий. Сущность технологии визуального проектирова" +
        "ние программ.");
            this.domainUpDown7.Items.Add("Общие сведения о платформе Microsoft.NET. ");
            this.domainUpDown7.Items.Add("Краткая характеристика технологий программирования. Основные возможности платформ" +
        "ы .NET. Основные компоненты .NET. Языки программирования .NET. Понятия промежуто" +
        "чного языка, метаданных, манифеста.");
            this.domainUpDown7.Items.Add("Общие сведения о платформе Microsoft.NET. ");
            this.domainUpDown7.Items.Add("Краткая характеристика технологий программирования. Основные возможности платформ" +
        "ы .NET. Основные компоненты .NET. Языки программирования .NET. Состав и роль язы" +
        "ковой среды выполнения .NET (CLR).");
            this.domainUpDown7.Items.Add("Интегрированная среда разработки (IDE) Visual Studio.NET.");
            this.domainUpDown7.Items.Add("Назначение и состав IDE. Состав, назначение и краткая характеристика основных око" +
        "н IDE.");
            this.domainUpDown7.Items.Add("Проверка данных, вводимых пользователем.");
            this.domainUpDown7.Items.Add(resources.GetString("domainUpDown7.Items"));
            this.domainUpDown7.Items.Add("Проверка данных, вводимых пользователем.");
            this.domainUpDown7.Items.Add(resources.GetString("domainUpDown7.Items1"));
            this.domainUpDown7.Items.Add("Проверка данных, вводимых пользователем.");
            this.domainUpDown7.Items.Add(resources.GetString("domainUpDown7.Items2"));
            this.domainUpDown7.Items.Add("Работа с файлами. Элемент управления OpenFileDialog.");
            this.domainUpDown7.Items.Add("Особенности файлов и потоков. Основные диалоги Visual Studio.NET и их предназначе" +
        "ние. Основные свойства и порядок работы с диалогом OpenFileDialog. Этапы чтения " +
        "данных из файла.");
            this.domainUpDown7.Items.Add("Работа с файлами. Элемент управления SaveFileDialog.");
            this.domainUpDown7.Items.Add("Особенности файлов и потоков. Основные диалоги Visual Studio.NET и их предназначе" +
        "ние. Основные свойства и порядок работы с диалогом SaveFileDialog. Этапы записи " +
        "данных в файл.");
            this.domainUpDown7.Items.Add("JSON-сериализация.");
            this.domainUpDown7.Items.Add("Структура JSON-файла. Особенности JSON-сериализации одномерных и многомерных масс" +
        "ивов. Пример JSON-сериализации двумерного массива. Сравнение JSON и XML форматов" +
        ". ");
            this.domainUpDown7.Items.Add("XML-сериализация.");
            this.domainUpDown7.Items.Add("Структура Xml-файла. Особенности Xml-сериализации. Пример Xml-сериализации двумер" +
        "ного массива. Сравнение Json и Xml форматов.  ");
            this.domainUpDown7.Items.Add("Язык XML.");
            this.domainUpDown7.Items.Add(resources.GetString("domainUpDown7.Items3"));
            this.domainUpDown7.Items.Add("Язык XML.");
            this.domainUpDown7.Items.Add(resources.GetString("domainUpDown7.Items4"));
            this.domainUpDown7.Items.Add("Язык XML.");
            this.domainUpDown7.Items.Add(resources.GetString("domainUpDown7.Items5"));
            this.domainUpDown7.Items.Add("Создание Windows Forms-приложения. ");
            this.domainUpDown7.Items.Add("Этапы разработки приложения. Назначение и особенности работы с дизайнером Windows" +
        " Forms. Порядок создания простейшего Windows Forms-приложения.");
            this.domainUpDown7.Items.Add("Формы в Windows Forms.");
            this.domainUpDown7.Items.Add("Назначение и состав формы. Типы Windows Forms-приложений. Основные свойства, мето" +
        "ды и события класса Form.");
            this.domainUpDown7.Items.Add("Формы в Windows Forms.");
            this.domainUpDown7.Items.Add("Назначение и состав формы. Типы Windows Forms-приложений. Порядок создания прилож" +
        "ения с несколькими формами.");
            this.domainUpDown7.Items.Add("Формы в Windows Forms.");
            this.domainUpDown7.Items.Add("Назначение и состав формы. Типы Windows Forms-приложений. Модальная и немодальная" +
        " формы. Порядок создания приложения с несколькими формами.");
            this.domainUpDown7.Items.Add("Формы в Windows Forms.");
            this.domainUpDown7.Items.Add("Назначение и состав формы. Типы Windows Forms-приложений. Способы передачи данных" +
        " между формами. Порядок передачи данных между формами.");
            this.domainUpDown7.Items.Add("Работа с графикой в Windows Forms.");
            this.domainUpDown7.Items.Add("Достоинства и недостатки GDI+. Базовые пространства имен GDI+. Классы, структуры " +
        "и базовые типы пространства имен System.Drawing. Система координат элемента упра" +
        "вления GDI+.");
            this.domainUpDown7.Items.Add("Возможности класса Graphics.");
            this.domainUpDown7.Items.Add("Назначение класса. Основные методы класса. Событие Paint и особенности работы с н" +
        "им. Способы перерисовки формы. Пример рисования на форме. Метод Invalidate, и ос" +
        "обенности работы с ним.");
            this.domainUpDown7.Items.Add("Управление цветом – структура Color.");
            this.domainUpDown7.Items.Add("ARGB-модель цвета. Основные константы, свойства и методы структуры Color. Пример " +
        "задания цвета и рисования на форме.");
            this.domainUpDown7.Items.Add("Элемент управления “диалог выбора цвета” – ColorDialog.");
            this.domainUpDown7.Items.Add("Назначение и порядок работы с элементом управления. Пример использования диалога " +
        "выбора цвета при рисовании на форме.");
            this.domainUpDown7.Items.Add("Рисование линий и прямоугольников в Windows Forms. ");
            this.domainUpDown7.Items.Add("Методы Graphics для изображения линий и прямоугольников. Назначение, методы и сво" +
        "йства класса Pen. Значения перечисления DashStyle. Пример рисования линий и прям" +
        "оугольников на форме.");
            this.domainUpDown7.Items.Add("Рисование линий и эллипсов в Windows Forms. ");
            this.domainUpDown7.Items.Add("Методы Graphics для изображения линий и эллипсов. Назначение, методы и свойства к" +
        "ласса Pen. Значения перечисления DashStyle. Пример рисования линий и эллипсов на" +
        " форме.");
            this.domainUpDown7.Items.Add("Рисование дуг в Windows Forms. ");
            this.domainUpDown7.Items.Add("Методы Graphics для изображения дуг. Назначение, методы и свойства класса Pen. Пр" +
        "имер рисования дуг и заливки секторов эллипса.");
            this.domainUpDown7.Items.Add("Делегаты в .NET Framework.");
            this.domainUpDown7.Items.Add("Синтаксис объявления делегата. Групповая адресация. Свойства, операции и методы д" +
        "елегата. Пример работы с делегатом.");
            this.domainUpDown7.Items.Add("Анонимные функции.");
            this.domainUpDown7.Items.Add("Типы анонимных функций. Использование анонимного метода с параметром. Возврат зна" +
        "чения из анонимного метода. Пример работы с использованием анонимного метода.");
            this.domainUpDown7.Items.Add("Лямбда-выражение.");
            this.domainUpDown7.Items.Add("Типы анонимных функций. Типы лямбда-выражений. Синтаксис использования лямбда-выр" +
        "ажений. Пример работы с использованием одиночного и блочного лямбда-выражений.");
            this.domainUpDown7.Items.Add("Обобщенные делегаты в .NET Framework.");
            this.domainUpDown7.Items.Add("Типы обобщенных делегатов. Пример использования делегатов Action, Func ");
            this.domainUpDown7.Items.Add("и Predicate.");
            this.domainUpDown7.Items.Add("Язык интегрированных запросов (LINQ  to  Objects).");
            this.domainUpDown7.Items.Add("Источники данных, совместимые с LINQ. Интерфейс IEnumerable<T>. Пример использова" +
        "ния LINQ.");
            this.domainUpDown7.Items.Add("Основные операторы LINQ.");
            this.domainUpDown7.Items.Add("Особенности использования операторов from, where, select, orderby. Примеры исполь" +
        "зования операторов from, where, select, orderby. ");
            this.domainUpDown7.Items.Add("Основные операторы LINQ.");
            this.domainUpDown7.Items.Add("Особенности использования операторов group, join, let, equals. Примеры использова" +
        "ния операторов group, join, let, equals.");
            this.domainUpDown7.Items.Add("Основные операторы LINQ.");
            this.domainUpDown7.Items.Add("Особенности использования операторов from, where, select. Анонимный тип. Примеры " +
        "использования операторов from, where, select и анонимного типа.");
            this.domainUpDown7.Items.Add("Методы запроса в LINQ.");
            this.domainUpDown7.Items.Add("Основные методы запросов в LINQ и их особенности. Два режима выполнения запроса. " +
        "Примеры использования методы запросов from, where, select, orderby с лямбда-выра" +
        "жениями. ");
            this.domainUpDown7.Items.Add("Parallel Linq to Object.");
            this.domainUpDown7.Items.Add("Особенности языка PLinq. Реализация параллельного запроса. Предохранение порядка " +
        "результатов. Управление параллелизмом. Пример параллельного запроса с предохране" +
        "нием порядка.");
            this.domainUpDown7.Items.Add("Linq to XML.");
            this.domainUpDown7.Items.Add("Особенности, основные операции, классы и методы языка Linq to XML. Функциональное" +
        " конструирование технологии Linq to XML. Пример вставки в Xml-файл.");
            this.domainUpDown7.Items.Add("Linq to XML.");
            this.domainUpDown7.Items.Add("Особенности, основные операции, классы и методы языка Linq to XML.  Примеры выбор" +
        "ки и вывода из Xml-файла.");
            this.domainUpDown7.Items.Add("Linq to XML.");
            this.domainUpDown7.Items.Add("Особенности, основные операции, классы и методы языка Linq to XML.  Запросы в Lin" +
        "q to XML. Пример запроса с фильтрацией, сортировкой и агрегированием.");
            this.domainUpDown7.Items.Add("Linq to XML.");
            this.domainUpDown7.Items.Add("Особенности, основные операции, классы и методы Linq to XML. Операции редактирова" +
        "ния, удаления и вставки. Примеры с редактированием, удалением и вставкой в Linq " +
        "to XML.");
            this.domainUpDown7.Items.Add("Особенности WPF.");
            this.domainUpDown7.Items.Add("Недостатки Windows Forms. Особенности (достоинства) WPF. Архитектура WPF.");
            this.domainUpDown7.Items.Add("Особенности языка разметки XAML.");
            this.domainUpDown7.Items.Add("Особенности XAML. Структура WPF-приложения. Структура XAML разметки пустого окна." +
        " Пример создания интерфейса в XAML – описание свойств и обработчиков в разметке." +
        "");
            this.domainUpDown7.Items.Add("Контейнеры компоновки WPF. ");
            this.domainUpDown7.Items.Add("Основные контейнеры компоновки. Контейнер Grid, его предназначение и свойства. Пр" +
        "имер использования контейнер Grid.");
            this.domainUpDown7.Items.Add("Контейнер StackPanel, его предназначение и свойства. Пример использования контейн" +
        "ер StackPanel.");
            this.domainUpDown7.Items.Add("Контейнеры компоновки WPF. ");
            this.domainUpDown7.Items.Add("Основные контейнеры компоновки. Контейнер DockPanel, его предназначение и свойств" +
        "а. Пример использования контейнер DockPanel.");
            this.domainUpDown7.Items.Add("Контейнер WrapPanel, его предназначение и свойства. Пример использования контейне" +
        "р WrapPanel. Вложение контейнеров компоновки.");
            this.domainUpDown7.Items.Add("Контейнеры компоновки WPF. ");
            this.domainUpDown7.Items.Add("Основные контейнеры компоновки. Контейнер UniformGrid, его предназначение и свойс" +
        "тва. Пример использования контейнер UniformGrid.");
            this.domainUpDown7.Items.Add("Контейнер Canvas, его предназначение и свойства, Z-порядок. Пример использования " +
        "контейнер Canvas. ");
            this.domainUpDown7.Items.Add("Особенности работы с элементом управления Button в WPF.");
            this.domainUpDown7.Items.Add("Предназначение и основные свойства Button. Пример использования кнопки с картинко" +
        "й.");
            this.domainUpDown7.Items.Add("Особенности работы с элементом управления Image в WPF.");
            this.domainUpDown7.Items.Add("Предназначение и основные свойства Image. Способы помещения картинки в Image. Фор" +
        "маты URI в XAML-разметке. Пример использования элемента Image.");
            this.domainUpDown7.Items.Add("Особенности работы с элементом управления DataGrid в WPF.");
            this.domainUpDown7.Items.Add("Предназначение и основные свойства DataGrid. Заполнение DataGrid данными. Пример " +
        "использования элемента DataGrid.");
            this.domainUpDown7.Items.Add("Особенности работы с ресурсами в WPF.");
            this.domainUpDown7.Items.Add("Назначение и виды ресурсов. Особенности ресурсов сборки.");
            this.domainUpDown7.Items.Add("Пример использования в разметке ресурсов сборки.");
            this.domainUpDown7.Location = new System.Drawing.Point(16, 153);
            this.domainUpDown7.Name = "domainUpDown7";
            this.domainUpDown7.ReadOnly = true;
            this.domainUpDown7.Size = new System.Drawing.Size(10, 20);
            this.domainUpDown7.TabIndex = 8;
            this.domainUpDown7.Visible = false;
            // 
            // domainUpDown8
            // 
            this.domainUpDown8.BackColor = System.Drawing.SystemColors.Control;
            this.domainUpDown8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.domainUpDown8.Items.Add("Узагальнена структура обчислювача. Структура ЦОМ. Програма, команда.");
            this.domainUpDown8.Items.Add("Узагальнена структура обчислювача. Оперативний запам’ятовуючий пристрій (ОЗП). Си" +
        "стема команд");
            this.domainUpDown8.Items.Add("Узагальнена структура обчислювача. Формати команд.");
            this.domainUpDown8.Items.Add("Елементи програмування ЦОМ. Організація лінійних програм.");
            this.domainUpDown8.Items.Add("Елементи програмування ЦОМ. Організація розгалужень");
            this.domainUpDown8.Items.Add("Інші способи адресації. Неявна адресація");
            this.domainUpDown8.Items.Add("Інші способи адресації. Безпосередня адресація");
            this.domainUpDown8.Items.Add("Інші способи адресації. Пряма адресація");
            this.domainUpDown8.Items.Add("Інші способи адресації. Непряма адресація");
            this.domainUpDown8.Items.Add("Вибір системи команд");
            this.domainUpDown8.Items.Add("Оцінка технічних характеристик процесора. Розрахунок формату команд");
            this.domainUpDown8.Items.Add("Оцінка технічних характеристик процесора. Розрахунок обсягу ОЗП");
            this.domainUpDown8.Items.Add("Оцінка технічних характеристик процесора. Розрахунок числа циклів");
            this.domainUpDown8.Items.Add("Мова операційних схем та мікропрограм. Основні поняття.");
            this.domainUpDown8.Items.Add("Структура операційного пристрою");
            this.domainUpDown8.Items.Add("Мова операційних схем");
            this.domainUpDown8.Items.Add("Граф мікропрограми");
            this.domainUpDown8.Items.Add("Поняття й різновид операційних блоків");
            this.domainUpDown8.Items.Add("Операційні блоки. Тригери");
            this.domainUpDown8.Items.Add("Операційні блоки. Регістри");
            this.domainUpDown8.Items.Add("Операційні блоки. Міжрегістрові передачі");
            this.domainUpDown8.Items.Add("Операційні блоки. Магістралі");
            this.domainUpDown8.Items.Add("Операційні блоки. Зсувні регистри");
            this.domainUpDown8.Items.Add("Операційні блоки. Лічильники");
            this.domainUpDown8.Items.Add("Операційні блоки. Суматори");
            this.domainUpDown8.Items.Add("Операційні блоки. Схеми порівняння");
            this.domainUpDown8.Items.Add("Операційні блоки. Дешифратор");
            this.domainUpDown8.Items.Add("Операційні блоки. Шифратор");
            this.domainUpDown8.Items.Add("Операційні блоки. Мультиплексор");
            this.domainUpDown8.Items.Add("Операційні блоки. Демультиплексор");
            this.domainUpDown8.Items.Add("Операційні блоки. Арифметико-логічні пристрої");
            this.domainUpDown8.Items.Add("Операційні блоки. Постійний запам’ятовуючий пристрій");
            this.domainUpDown8.Items.Add("Операційні блоки. Оперативний запам’ятовуючий пристрій");
            this.domainUpDown8.Items.Add("Операційні блоки. Зовнішні операційні пристрої");
            this.domainUpDown8.Items.Add("Пристрій управління");
            this.domainUpDown8.Items.Add("Оперативний запам&#39;ятовуючий пристрій");
            this.domainUpDown8.Items.Add("Арифметичний пристрій");
            this.domainUpDown8.Items.Add("Процесор і його зв&#39;язок із зовнішніми пристроями");
            this.domainUpDown8.Items.Add("Узагальнений граф роботи обчислювача");
            this.domainUpDown8.Items.Add("Операційна схема та граф-схема алгоритму роботи процесора");
            this.domainUpDown8.Items.Add("Система команд процесора");
            this.domainUpDown8.Items.Add("Вибір основних операційних блоків");
            this.domainUpDown8.Items.Add("Операційна схема процесора");
            this.domainUpDown8.Items.Add("Граф-схема алгоритму роботи процесора");
            this.domainUpDown8.Items.Add("Перелік операційних блоків");
            this.domainUpDown8.Items.Add("Перелік керуючих сигналів");
            this.domainUpDown8.Items.Add("Загальні відомості про керуючі автомати. Декомпозиція операційного пристрою");
            this.domainUpDown8.Items.Add("Загальні відомості про керуючі автомати. Внутрішні стани керуючого автомата");
            this.domainUpDown8.Items.Add("Загальні відомості про керуючі автомати. Типи керуючих автоматів");
            this.domainUpDown8.Items.Add("Керуючі автомати з жорсткою логікою. Закони функціонування керуючих автоматів");
            this.domainUpDown8.Items.Add("Керуючі автомати з жорсткою логікою. Способи переходу автомата з одного стану в і" +
        "нший");
            this.domainUpDown8.Items.Add("Етапи синтезу керуючого автомата");
            this.domainUpDown8.Items.Add("Побудова закодованої граф-схеми алгоритму");
            this.domainUpDown8.Items.Add("Вибір типу автомата і побудова розміченої ГСА. Розмічений граф автомата МУРА");
            this.domainUpDown8.Items.Add("Вибір типу автомата і побудова розміченої ГСА. Розмічений граф автомата МІЛІ");
            this.domainUpDown8.Items.Add("Синтез комбінаційних схем автоматів. Синтез комбінаційної схеми автомата МУРА");
            this.domainUpDown8.Items.Add("Синтез комбінаційних схем автоматів. Синтез комбінаційної схеми автомата МІЛІ");
            this.domainUpDown8.Location = new System.Drawing.Point(15, 153);
            this.domainUpDown8.Name = "domainUpDown8";
            this.domainUpDown8.ReadOnly = true;
            this.domainUpDown8.Size = new System.Drawing.Size(12, 20);
            this.domainUpDown8.TabIndex = 9;
            this.domainUpDown8.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(309, 101);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(147, 20);
            this.progressBar1.Step = 4;
            this.progressBar1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(518, 189);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.domainUpDown8);
            this.Controls.Add(this.domainUpDown7);
            this.Controls.Add(this.domainUpDown6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.domainUpDown4);
            this.Controls.Add(this.domainUpDown3);
            this.Controls.Add(this.domainUpDown2);
            this.Controls.Add(this.domainUpDown5);
            this.Controls.Add(this.domainUpDown1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Exam";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.DomainUpDown domainUpDown3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DomainUpDown domainUpDown4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DomainUpDown domainUpDown5;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.SaveFileDialog save;
        public System.Windows.Forms.OpenFileDialog open;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DomainUpDown domainUpDown6;
        private System.Windows.Forms.DomainUpDown domainUpDown7;
        private System.Windows.Forms.DomainUpDown domainUpDown8;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

