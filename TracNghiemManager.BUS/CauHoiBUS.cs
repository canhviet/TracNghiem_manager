using Microsoft.Office.Interop.Word;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using TracNghiemManager.DAO;
using TracNghiemManager.DTO;
using Word = Microsoft.Office.Interop.Word;

namespace TracNghiemManager.BUS
{
    public class CauHoiBUS
    {
        public CauHoiDAO cauHoiDAO;
        public CauHoiBUS()
        {
            cauHoiDAO = CauHoiDAO.getInstance();
        }
        public List<CauHoiDTO> getAll()
        {

            return cauHoiDAO.GetAll();
        }

        public string Add(CauHoiDTO t)
        {
            if (cauHoiDAO.Add(t))
            {
                return "Thêm câu hỏi thành công!";
            }
            return "Thêm câu hỏi thất bại!";
        }

        public string Update(CauHoiDTO t)
        {
            if (cauHoiDAO.Update(t)) { return "Cập nhật câu hỏi thành công!"; }
            return "Cập nhật câu hỏi thất bại!";
        }
        public string Delete(int id)
        {
            if (cauHoiDAO.Delete(id))
            {
                return "Xõa câu hỏi thành công";
            }
            return "Xóa câu hỏi thất bại";
        }
        public int GetAutoIncrement()
        {
            return cauHoiDAO.GetAutoIncrement();
        }
        public CauHoiDTO getById(int id)
        {
            return cauHoiDAO.GetById(id);
        }

		public void ExportToWord(string wordFilePath)
		{
			Dictionary<string, List<Tuple<string, bool>>> dict = cauHoiDAO.GetCauHoiVaCauTraLoi();

			Word.Application wordApp = new Word.Application();
			Word.Document wordDoc = wordApp.Documents.Add();

			int questionNumber = 1;
			foreach (var item in dict)
			{
				AddText(wordDoc, "Câu " + questionNumber + ": " + item.Key + "\n", false);

				char[] answerChars = { 'A', 'B', 'C', 'D' };
				for (int i = 0; i < item.Value.Count; i++)
				{
					string cauTraLoi = answerChars[i % answerChars.Length] + ". " + item.Value[i].Item1;
					AddText(wordDoc, cauTraLoi + "\n", item.Value[i].Item2);
				}
				questionNumber++;
			}
			wordDoc.SaveAs2(wordFilePath);
			wordDoc.Close();
			wordApp.Quit();
		}
		public void AddText(Word.Document doc, string text, bool underline)
		{
			Word.Range rng = doc.Content;
			rng.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
			rng.InsertAfter(text);
			if (underline)
			{
				rng.Font.Underline = Word.WdUnderline.wdUnderlineSingle;
			}
		}
        public List<CauHoiDTO> GetAllByMaNguoiTao(int ma)
		{
			return cauHoiDAO.GetAllByMaNguoiTao(ma);
		}
	}
}
