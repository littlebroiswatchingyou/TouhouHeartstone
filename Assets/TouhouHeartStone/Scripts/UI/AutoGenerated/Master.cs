//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UI
{
    using System;
    using UnityEngine;
    using UnityEngine.UI;
    using BJSYGameCore.UI;
    
    public partial class Master : UIObject
    {
        protected override void Awake()
        {
            base.Awake();
            this.autoBind();
            this.onAwake();
        }
        public void autoBind()
        {
            this._HighlightImage = this.transform.Find("Highlight").GetComponent<Image>();
            this._Mask = this.transform.Find("Mask").GetComponent<Mask>();
            this._Image = this.transform.Find("Mask").Find("Image").GetComponent<Image>();
            this._FrameImage = this.transform.Find("Frame").GetComponent<Image>();
            this._AtkImage = this.transform.Find("Atk").GetComponent<Image>();
            this._AttackText = this.transform.Find("Atk").Find("AttackText").GetComponent<Text>();
            this._HpImage = this.transform.Find("Hp").GetComponent<Image>();
            this._HpText = this.transform.Find("Hp").Find("HpText").GetComponent<Text>();
            this._ArmorImage = this.transform.Find("Armor").GetComponent<Image>();
            this._ArmorText = this.transform.Find("Armor").Find("ArmorText").GetComponent<Text>();
        }
        [SerializeField()]
        private Image _HighlightImage;
        public Image HighlightImage
        {
            get
            {
                if ((this._HighlightImage == null))
                {
                    this._HighlightImage = this.transform.Find("Highlight").GetComponent<Image>();
                }
                return this._HighlightImage;
            }
        }
        [SerializeField()]
        private Mask _Mask;
        public Mask Mask
        {
            get
            {
                if ((this._Mask == null))
                {
                    this._Mask = this.transform.Find("Mask").GetComponent<Mask>();
                }
                return this._Mask;
            }
        }
        [SerializeField()]
        private Image _Image;
        public Image Image
        {
            get
            {
                if ((this._Image == null))
                {
                    this._Image = this.transform.Find("Mask").Find("Image").GetComponent<Image>();
                }
                return this._Image;
            }
        }
        [SerializeField()]
        private Image _FrameImage;
        public Image FrameImage
        {
            get
            {
                if ((this._FrameImage == null))
                {
                    this._FrameImage = this.transform.Find("Frame").GetComponent<Image>();
                }
                return this._FrameImage;
            }
        }
        [SerializeField()]
        private Image _AtkImage;
        public Image AtkImage
        {
            get
            {
                if ((this._AtkImage == null))
                {
                    this._AtkImage = this.transform.Find("Atk").GetComponent<Image>();
                }
                return this._AtkImage;
            }
        }
        [SerializeField()]
        private Text _AttackText;
        public Text AttackText
        {
            get
            {
                if ((this._AttackText == null))
                {
                    this._AttackText = this.transform.Find("Atk").Find("AttackText").GetComponent<Text>();
                }
                return this._AttackText;
            }
        }
        [SerializeField()]
        private Image _HpImage;
        public Image HpImage
        {
            get
            {
                if ((this._HpImage == null))
                {
                    this._HpImage = this.transform.Find("Hp").GetComponent<Image>();
                }
                return this._HpImage;
            }
        }
        [SerializeField()]
        private Text _HpText;
        public Text HpText
        {
            get
            {
                if ((this._HpText == null))
                {
                    this._HpText = this.transform.Find("Hp").Find("HpText").GetComponent<Text>();
                }
                return this._HpText;
            }
        }
        [SerializeField()]
        private Image _ArmorImage;
        public Image ArmorImage
        {
            get
            {
                if ((this._ArmorImage == null))
                {
                    this._ArmorImage = this.transform.Find("Armor").GetComponent<Image>();
                }
                return this._ArmorImage;
            }
        }
        [SerializeField()]
        private Text _ArmorText;
        public Text ArmorText
        {
            get
            {
                if ((this._ArmorText == null))
                {
                    this._ArmorText = this.transform.Find("Armor").Find("ArmorText").GetComponent<Text>();
                }
                return this._ArmorText;
            }
        }
        partial void onAwake();
        public enum Highlight
        {
            Green,
            None,
            Yellow,
        }
        public Highlight HighlightController
        {
            get
            {
                return ((Highlight)(Enum.Parse(typeof(Highlight), this.getController("Highlight", Enum.GetNames(typeof(Highlight))))));
            }
            set
            {
                this.setController("Highlight", Enum.GetName(typeof(Highlight), value));
            }
        }
    }
}
