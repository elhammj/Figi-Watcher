using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tesseract;
using System.Drawing;
using System.Windows.Forms;

namespace SmartRefri
{
    public enum TesseractEngineMode : int
    {
        /// <summary>
        /// Run Tesseract only - fastest
        /// </summary>
        TESSERACT_ONLY = 0,

        /// <summary>
        /// Run Cube only - better accuracy, but slower
        /// </summary>
        CUBE_ONLY = 1,

        /// <summary>
        /// Run both and combine results - best accuracy
        /// </summary>
        TESSERACT_CUBE_COMBINED = 2,

        /// <summary>
        /// Specify this mode when calling init_*(),
        /// to indicate that any of the above modes
        /// should be automatically inferred from the
        /// variables in the language-specific config,
        /// command-line configs, or if not specified
        /// in any of the above should be set to the
        /// default OEM_TESSERACT_ONLY.
        /// </summary>
        DEFAULT = 3
    }

    public enum TesseractPageSegMode : int
    {
        /// <summary>
        /// Fully automatic page segmentation
        /// </summary>
        PSM_AUTO = 0,

        /// <summary>
        /// Assume a single column of text of variable sizes
        /// </summary>
        PSM_SINGLE_COLUMN = 1,

        /// <summary>
        /// Assume a single uniform block of text (Default)
        /// </summary>
        PSM_SINGLE_BLOCK = 2,

        /// <summary>
        /// Treat the image as a single text line
        /// </summary>
        PSM_SINGLE_LINE = 3,

        /// <summary>
        /// Treat the image as a single word
        /// </summary>
        PSM_SINGLE_WORD = 4,

        /// <summary>
        /// Treat the image as a single character
        /// </summary>
        PSM_SINGLE_CHAR = 5
    }

    public class TesseractOCREngine
    {
        public Image image;

        public TesseractOCREngine(Image image)
        {
            this.image = image;
            m_tesseract = new TesseractProcessor();
            bool succeed = m_tesseract.Init(m_path, m_lang, (int)TesseractEngineMode.DEFAULT);
            m_tesseract.SetVariable("tessedit_char_whitelist", "0123456789-.eExXpP/\\");
            m_tesseract.SetVariable("tessedit_pageseg_mode", ((int)TesseractPageSegMode.PSM_SINGLE_LINE).ToString());
            System.Environment.CurrentDirectory = System.IO.Path.GetFullPath(m_path);
        }

        private TesseractProcessor m_tesseract = null;

        private  string m_path = Application.StartupPath+@"\data\";
        private const string m_lang = "eng";

        private string Ocr()
        {
            m_tesseract.Clear();
            m_tesseract.ClearAdaptiveClassifier();
            return m_tesseract.Apply(image);
        }

        private DateTime extractExpiredDate(string text)
        {
            int eIndex=text.ToLower().LastIndexOf("e");
            int expIndex = text.ToLower().LastIndexOf("exp");
            if (expIndex == -1 && eIndex==-1)
                throw new Exception("Sorry, OCR Engine can't extract the Expired Date. Make sure the expired date image is correct.");
            if(expIndex!=-1)
                text = text.Substring(expIndex);
            else
                text = text.Substring(eIndex);
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            text=text.Substring(text.IndexOfAny(numbers));
            char[] spliters = { '-', '.', '\\', '/' };
            string[] parts = text.Split(spliters, StringSplitOptions.RemoveEmptyEntries);
            DateTime date = new DateTime(int.Parse(parts[2].Trim().Substring(0,4)), int.Parse(parts[1].Trim()), int.Parse(parts[0].Trim()));
            return date;
        }

        public DateTime GetExpiredDate()
        {
            return extractExpiredDate(Ocr());
        }
    }
}
