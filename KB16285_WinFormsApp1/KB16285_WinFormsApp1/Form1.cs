using Infragistics.Win.UltraWinGrid;
using System.Data;

namespace KB16285_WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ultraGrid1.DataSource = GetPeopleData();
        }

        private DataTable GetPeopleData()
        {
            var dt = new DataTable();

            var idColumn = dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("FamilyName", typeof(String));
            dt.Columns.Add("GivenName", typeof(String));
            dt.Columns.Add("Prefecture", typeof(String));
            dt.Columns.Add("City", typeof(String));
            dt.Columns.Add("Age", typeof(int));

            dt.Rows.Add([1, "玉木", "悦夫", "千葉県", "旭市", 48]);
            dt.Rows.Add([2, "服部", "光明", "神奈川県", "横浜市西区", 52]);
            dt.Rows.Add([3, "吉原", "明里", "千葉県", "松戸市", 53]);
            dt.Rows.Add([4, "二宮", "春子", "茨城県", "常陸太田市", 53]);
            dt.Rows.Add([5, "森谷", "健三郎", "千葉県", "市原市", 55]);
            dt.Rows.Add([6, "遠山", "紀之", "埼玉県", "北葛飾郡松伏町", 55]);
            dt.Rows.Add([7, "南", "明紀", "千葉県", "木更津市", 44]);
            dt.Rows.Add([8, "日比野", "正志", "栃木県", "栃木市", 23]);
            dt.Rows.Add([9, "上田", "定夫", "群馬県", "吾妻郡長野原町", 22]);
            dt.Rows.Add([10, "石本", "真哉", "茨城県", "水戸市", 46]);
            dt.Rows.Add([11, "会田", "雪弥", "群馬県", "館林市", 28]);
            dt.Rows.Add([12, "大熊", "直樹", "神奈川県", "横浜市西区", 20]);
            dt.Rows.Add([13, "小笠原", "彩加", "東京都", "西多摩郡奥多摩町", 52]);
            dt.Rows.Add([14, "宮下", "廣祐", "栃木県", "矢板市", 33]);
            dt.Rows.Add([15, "大石", "明音", "東京都", "港区", 39]);
            dt.Rows.Add([16, "寺内", "真由美", "群馬県", "館林市", 56]);
            dt.Rows.Add([17, "石岡", "春香", "東京都", "港区", 24]);
            dt.Rows.Add([18, "富岡", "美沙", "東京都", "港区", 46]);
            dt.Rows.Add([19, "大下", "英晴", "茨城県", "古河市", 35]);
            dt.Rows.Add([20, "山口", "麻子", "茨城県", "神栖市", 47]);
            dt.Rows.Add([21, "平本", "康之", "埼玉県", "飯能市", 54]);
            dt.Rows.Add([22, "手島", "麗華", "埼玉県", "白岡市", 38]);
            dt.Rows.Add([23, "春日", "福", "千葉県", "木更津市", 21]);
            dt.Rows.Add([24, "石倉", "裕之", "埼玉県", "上尾市", 29]);
            dt.Rows.Add([25, "秋田", "斗碧", "群馬県", "太田市", 31]);
            dt.Rows.Add([26, "滝田", "辰雄", "茨城県", "稲敷郡阿見町", 45]);
            dt.Rows.Add([27, "長坂", "由良", "埼玉県", "三郷市", 47]);
            dt.Rows.Add([28, "栗本", "慶一", "埼玉県", "鶴ヶ島市", 58]);
            dt.Rows.Add([29, "井原", "利幸", "埼玉県", "越谷市", 50]);
            dt.Rows.Add([30, "川上", "陽一郎", "埼玉県", "鴻巣市", 38]);
            dt.Rows.Add([31, "堀", "優羽", "東京都", "千代田区", 22]);
            dt.Rows.Add([32, "宮城", "朋香", "神奈川県", "横浜市都筑区", 56]);
            dt.Rows.Add([33, "坂口", "春音", "栃木県", "那須塩原市", 22]);
            dt.Rows.Add([34, "丹羽", "俊雄", "埼玉県", "ふじみ野市", 28]);
            dt.Rows.Add([35, "目黒", "夏帆", "群馬県", "伊勢崎市", 28]);
            dt.Rows.Add([36, "芦田", "孝利", "神奈川県", "鎌倉市", 22]);
            dt.Rows.Add([37, "八木", "数子", "神奈川県", "川崎市中原区", 23]);
            dt.Rows.Add([38, "安永", "奈保美", "群馬県", "桐生市", 46]);
            dt.Rows.Add([39, "稲葉", "米子", "群馬県", "桐生市", 56]);
            dt.Rows.Add([40, "松川", "正好", "千葉県", "木更津市", 32]);
            dt.Rows.Add([41, "越智", "和佳子", "栃木県", "佐野市", 39]);
            dt.Rows.Add([42, "塩見", "知子", "茨城県", "つくば市", 50]);
            dt.Rows.Add([43, "坂東", "日和", "群馬県", "富岡市", 32]);
            dt.Rows.Add([44, "小松", "正美", "栃木県", "塩谷郡塩谷町", 50]);
            dt.Rows.Add([45, "菅原", "吉男", "埼玉県", "さいたま市桜区", 25]);
            dt.Rows.Add([46, "寺田", "郁夫", "茨城県", "東茨城郡茨城町", 39]);
            dt.Rows.Add([47, "今西", "栄三郎", "栃木県", "小山市", 36]);
            dt.Rows.Add([48, "長沢", "小百合", "東京都", "新宿区", 22]);
            dt.Rows.Add([49, "神保", "武雄", "栃木県", "那須烏山市", 27]);
            dt.Rows.Add([50, "河上", "芳樹", "茨城県", "取手市", 55]);

            dt.PrimaryKey = [idColumn];

            return dt;
        }

        private void ultraGrid1_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            e.Layout.GroupByBox.Hidden = true;
        }

        private int _firstRowIndexInView = -1;

        // [スクロール位置の保存] ボタン クリック イベント ハンドラー
        private void button1_Click(object sender, EventArgs e)
        {
            _firstRowIndexInView = ultraGrid1.DisplayLayout.RowScrollRegions[0].VisibleRows[0].Row.Index;
        }

        // [スクロール位置の復元] ボタン クリック イベント ハンドラー
        private void button2_Click(object sender, EventArgs e)
        {
            if(_firstRowIndexInView >= 0 && _firstRowIndexInView < ultraGrid1.Rows.Count)
            {
                ultraGrid1.DisplayLayout.RowScrollRegions[0].FirstRow = ultraGrid1.Rows[_firstRowIndexInView];
            }
        }
    }
}
