using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 河北干部网络学院挂机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string classID = "";//课程ID
        private string webuserAgent = "";//代理
        private CookieContainer cookieContainer_0 = null;//cookie
        private string uuid = "";
        private string ucid = "";
        private double lesson_location = 15;//"cmi.core.lesson_location":"1953.0"
        private int session_time = 27;//"cmi.core.session_time":"00:00:57" 
        private DateTime last_learn_time = DateTime.Now;//"last_learn_time":"2020-11-18 10:48:45"
        private long unknownId = 1576049078020;
        private bool isNewLesson = true;

        private bool LogIn()
        {
            try
            {
                string requestUriString = "http://www.hebgb.gov.cn/portal/j_security_check";
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
                httpWebRequest.Method = "POST";
                httpWebRequest.Accept = "*/*;";
                httpWebRequest.UserAgent = this.webuserAgent;
                httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                httpWebRequest.AllowAutoRedirect = true;
                httpWebRequest.CookieContainer = this.cookieContainer_0;
                httpWebRequest.KeepAlive = false;
                httpWebRequest.ProtocolVersion = HttpVersion.Version10;
                string s = string.Format("j_uri=%2Fportal%2Findex%21index.action&yzm=not&j_username={0}++&j_password={1}&imgcode=",
                    this.textBox_UserName.Text,
                    this.textBox_Password.Text);
                byte[] bytes = Encoding.UTF8.GetBytes(s);
                httpWebRequest.ContentLength = (long)bytes.Length;
                httpWebRequest.GetRequestStream().Write(bytes, 0, bytes.Length);
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
                string text = streamReader.ReadToEnd();
                httpWebResponse.Close();
                streamReader.Close();
                httpWebRequest.Abort();
                httpWebResponse.Close();
                this.cookieContainer_0 = httpWebRequest.CookieContainer;
                if (text.Contains("欢迎您"))
                {
                    this.button1.Text = "登录成功";
                    this.textBox_UserName.Enabled = false;
                    this.textBox_Password.Enabled = false;
                    this.button1.Enabled = false;
                    Thread.Sleep(1000);
                    return true;
                }
                else
                {
                    if (text.Contains("验证码输入错误"))
                    {
                        MessageBox.Show("登录失败！四位的数字验证码输入错误！");
                        return false;
                    }
                    if (text.Contains("用户名或密码输入错误"))
                    {
                        MessageBox.Show("登录失败！用户名或密码输入错误！请先上官网 www.hebgb.gov.cn 验证一下！也可能是网站升级造成登录失败。");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                this.Text = ex.Message.ToString();
                if (ex.Message.Contains("500"))
                {
                    MessageBox.Show("帐号登录状态异常1，请重新登录！期间不要在外面的浏览器登录帐号，不然会挤掉本程序的登录，造成学习失效！");
                }
                else if (ex.Message.Contains("操时"))
                {
                    MessageBox.Show("登录操时！");
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return false;
        }

        private bool GetClassList()
        {
            string selClassUrl = "";
            if (rb_BiXiu.Checked)
            {
                selClassUrl = "http://www.hebgb.gov.cn/student/course!list.action?course.course_type=0&init=yes";//必修
            }
            else if (rb_XuanXiu.Checked)
            {
                selClassUrl = "http://www.hebgb.gov.cn/student/course!list.action?course.course_type=1&init=yes";//选修
            }
            else
            {
                string classId = "0";//需获取
                selClassUrl = "http://www.hebgb.gov.cn/student/clazz!main.action?init&clazz.id=" + classId;
            }
            try
            {
                string ClassPageTxt = GetUrl(selClassUrl);
                if (!ClassPageTxt.Contains("欢迎您"))
                {
                    MessageBox.Show("帐号登录状态异常2，请重新登录！期间不要在外面的浏览器登录帐号，不然会挤掉本程序的登录，造成学习失效！");
                    return false;
                }

                string str_Tmp = "<img class=\"img\" title=";
                string[] array = ClassPageTxt.Split(new string[]
                {
                           str_Tmp
                }, StringSplitOptions.None);
                this.listBox_ClassList.Items.Clear();
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Contains("images/index_images/ico014.png"))
                    {
                        int length = array[i].IndexOf("images/index_images/ico014.png");
                        this.listBox_ClassList.Items.Add(array[i].Substring(0, length));
                    }
                }
                if (this.listBox_ClassList.Items.Count != 0)
                {
                    this.listBox_ClassList.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "  帐号登录状态异常2，请重新登录！期间不要在外面的浏览器登录帐号，不然会挤掉本程序的登录，造成学习失效！");
                return false;
            }
            return true;
        }

        private string GetUrl(string url)
        {
            this.webuserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; 360SE)";
            if (cookieContainer_0 == null) { cookieContainer_0 = new CookieContainer(); }
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Accept = "*/*";
            httpWebRequest.Method = "GET";
            httpWebRequest.UserAgent = this.webuserAgent;
            httpWebRequest.ContentType = "application/x-www-form-urlencoded";
            httpWebRequest.AllowAutoRedirect = true;
            httpWebRequest.CookieContainer = this.cookieContainer_0;
            httpWebRequest.KeepAlive = true;
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
            string htmlText = streamReader.ReadToEnd();
            httpWebResponse.Close();
            streamReader.Close();
            httpWebRequest.Abort();
            httpWebResponse.Close();
            this.cookieContainer_0 = httpWebRequest.CookieContainer;
            return htmlText;
        }
        //如果有多个匹配值 结果未知
        private string GetMidStr(string htmlText, string lhs, string rhs, bool hasLhs = false, bool hasRhs = false)
        {
            string str_Tmp = lhs;
            string[] array = htmlText.Split(new string[] { str_Tmp }, StringSplitOptions.None);
            string midStr = array.LastOrDefault().Split(new string[] { rhs }, StringSplitOptions.None).FirstOrDefault();
            if (hasLhs) { midStr = lhs + midStr; }
            if (hasRhs) { midStr += rhs; }
            return midStr;
        }

        private void StartStudy()
        {
            int indexS = this.listBox_ClassList.Text.IndexOf(">");
            int indexE = this.listBox_ClassList.Text.IndexOf("src=");
            int strLength = indexE - indexS;
            string strTmp = this.listBox_ClassList.Text.Substring(1, indexE - 3);
            if (!rb_XueXiBan.Checked)
            {
                indexS = this.listBox_ClassList.Text.IndexOf("%;\"></span></span>");
                indexE = this.listBox_ClassList.Text.IndexOf("%</span>");
                int lengthTmp = "%;\"></span></span>".Length;
                strLength = indexE - indexS - lengthTmp;
                indexS = this.listBox_ClassList.Text.IndexOf("videoList(");
                indexE = this.listBox_ClassList.Text.IndexOf(");");
                lengthTmp = "videoList(".Length;
                strLength = indexE - indexS - lengthTmp;
                this.classID = this.listBox_ClassList.Text.Substring(indexS + lengthTmp, strLength);
            }

            string htmlText = GetUrl("http://www.hebgb.gov.cn/portal/study!play.action?id=" + this.classID);
            if (htmlText.Contains("http://cdn.hebgb.gov.cn"))
            {
                string studyPercent = GetMidStr(htmlText, "<span style=\"margin-left: 5px;\">", "</span>");
                studyPercent = studyPercent.Replace("\r", "");
                studyPercent = studyPercent.Replace("\n", "");
                studyPercent = studyPercent.Replace("%", "");
                studyPercent = studyPercent.Replace(" ", "");
                double.TryParse(studyPercent, out double percent);
                if (percent > 99.9)
                {
                    timer_StydyHeartBeat.Stop();
                    timer_StydyHeartBeat.Enabled = false;
                }
                this.label_StudySchedule.Text = "当前课程学习进度:" + percent + "%";

                string realPlayUrl = GetMidStr(htmlText, "http://cdn.hebgb.gov.cn", "\"", true);
                string realPlayUrlUnescape = Uri.UnescapeDataString(realPlayUrl);
                string ucid_Tmp = GetMidStr(realPlayUrlUnescape, "\"ucid\":\"", "\"");
                string uuid_Tmp = GetMidStr(realPlayUrlUnescape, "\"uuid\":\"", "\"");
                if (uuid_Tmp != uuid && ucid_Tmp != ucid)
                {
                    isNewLesson = true;
                    uuid = uuid_Tmp;
                    ucid = ucid_Tmp;

                    lesson_location = 15;//"cmi.core.lesson_location":"1953.0"
                    session_time = 27;//"cmi.core.session_time":"00:00:57" 
                    timer_StydyHeartBeat.Enabled = true;
                    timer_StydyHeartBeat.Start();
                }
            }
            else
            {
                MessageBox.Show("起床查BUG咯！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox_UserName.Text == "" || this.textBox_Password.Text == "")
            {
                MessageBox.Show("账号密码不能为空！");
            }
            else
            {
                this.listBox_ClassList.Items.Clear();

                if (LogIn())
                {
                    if (GetClassList())
                    {
                        StartStudy();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetUrl("http://www.hebgb.gov.cn/portal/index!index.action");
        }
        
        private void listBox_ClassList_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartStudy();
        }

        private void timer_StudyScheduleCheck_Tick(object sender, EventArgs e)
        {
            if (GetClassList())
                StartStudy();
        }

        private void timer_StydyHeartBeat_Tick(object sender, EventArgs e)
        {
            if (isNewLesson)
            {
                lesson_location = 15.0;
                last_learn_time = DateTime.Now;
            }
            isNewLesson = false;
            DateTime timeNow = DateTime.Now;
            long ticks = timeNow.Ticks - last_learn_time.Ticks;            
            session_time = (session_time + 30) % 60;
            lesson_location += 30;
            string tickUrl = "http://www.hebgb.gov.cn/portal/study!seek.action?callback=showData&uuid="
                + uuid + "&id=" + ucid
                + "&serializeSco={\"0\":{\"cmi.core.exit\":\"logout\",\"cmi.core.lesson_location\":\""
                + lesson_location.ToString("0.0")
                + "\",\"cmi.core.session_time\":\"00:00:"
                + session_time + "\",\"cmi.core.entry\":\"resume\",\"last_learn_time\":\""
                + last_learn_time.ToString("yyyy-MM-dd HH:mm:ss") + "\"}}&duration=30000&a=提交&_="
                + unknownId.ToString() + "\"";

            label_Test.Text = GetUrl(tickUrl); 

            ///*需要发送的包
            //http://www.hebgb.gov.cn/portal/study!seek.action?callback=showData&
            //uuid=331bc2bf-1e35-41cc-9748-897637156c18&
            //id=62289911&
            //serializeSco={"0":{"cmi.core.exit":"logout","cmi.core.lesson_location":"1953.0","cmi.core.session_time":"00:00:57","cmi.core.entry":"resume","last_learn_time":"2020-11-18 10:48:45"}}&
            //duration=30000&
            //a=提交&
            //_=1605665805851*/
        }
    }
}
