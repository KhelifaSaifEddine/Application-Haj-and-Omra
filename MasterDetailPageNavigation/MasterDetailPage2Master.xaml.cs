using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailPageNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage2Master : ContentPage
    {
        public ListView ListView;

        public MasterDetailPage2Master()
        {
            InitializeComponent();
          

            BindingContext = new MasterDetailPage2MasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailPage2MasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailPage2MenuItem> MenuItems { get; set; }

            public MasterDetailPage2MasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailPage2MenuItem>(new[]
                {
                    new MasterDetailPage2MenuItem { Idf = 0, Title =   " الفاتحة "     },
                    new MasterDetailPage2MenuItem { Idf = 1, Title =   " البقرة "      },
                    new MasterDetailPage2MenuItem { Idf = 2, Title =   " آل عمران "    },
                    new MasterDetailPage2MenuItem { Idf = 3, Title =   " النساء "      },
                    new MasterDetailPage2MenuItem { Idf = 4, Title =   " المائدة "     },
                    new MasterDetailPage2MenuItem { Idf = 5, Title =   " الأنعام "      },
                    new MasterDetailPage2MenuItem { Idf = 6, Title =   " الأعراف "      },
                    new MasterDetailPage2MenuItem { Idf = 7, Title =   " الأنفال "      },
                    new MasterDetailPage2MenuItem { Idf = 8, Title =   " التوبة "      },
                    new MasterDetailPage2MenuItem { Idf = 9, Title =   " يونس "        },
                    new MasterDetailPage2MenuItem { Idf = 10, Title =  " هود "         },
                    new MasterDetailPage2MenuItem { Idf = 11, Title =  " يوسف "        },
                    new MasterDetailPage2MenuItem { Idf = 12, Title =  " الرعد "       },
                    new MasterDetailPage2MenuItem { Idf = 13, Title = "إبراهيم "       },
                    new MasterDetailPage2MenuItem { Idf = 14, Title = " الحجر "        },
                    new MasterDetailPage2MenuItem { Idf = 15, Title = " النحل "        },
                    new MasterDetailPage2MenuItem { Idf = 16, Title = " الإسراء "       },
                    new MasterDetailPage2MenuItem { Idf = 17, Title = " الكهف "        },
                    new MasterDetailPage2MenuItem { Idf = 18, Title = " مريم "         },
                    new MasterDetailPage2MenuItem { Idf = 19, Title = " طه "           },
                    new MasterDetailPage2MenuItem { Idf = 20, Title = " الأنبياء "      },
                    new MasterDetailPage2MenuItem { Idf = 21, Title = " الحج "         },
                    new MasterDetailPage2MenuItem { Idf = 22, Title = " المؤمنون "     },
                    new MasterDetailPage2MenuItem { Idf = 23, Title = "النور"          },
                    new MasterDetailPage2MenuItem { Idf = 24, Title = " الفرقان "      },
                    new MasterDetailPage2MenuItem { Idf = 25, Title = " الشعراء "      },
                    new MasterDetailPage2MenuItem { Idf = 26, Title = " النمل "        },
                    new MasterDetailPage2MenuItem { Idf = 27, Title = " القصص "        },
                    new MasterDetailPage2MenuItem { Idf = 28, Title = " العنكبوت "     },
                    new MasterDetailPage2MenuItem { Idf = 29, Title = " الروم "        },
                    new MasterDetailPage2MenuItem { Idf = 30, Title = " لقمان "        },
                    new MasterDetailPage2MenuItem { Idf = 31, Title = " السجدة "       },
                    new MasterDetailPage2MenuItem { Idf = 32, Title = " الأحزاب "       },
                    new MasterDetailPage2MenuItem { Idf = 33, Title = " سبأ "          },
                    new MasterDetailPage2MenuItem { Idf = 34, Title = " فاطر "         },
                    new MasterDetailPage2MenuItem { Idf = 35, Title = " يس "           },
                    new MasterDetailPage2MenuItem { Idf = 36, Title = " الصافات "      },
                    new MasterDetailPage2MenuItem { Idf = 37, Title = " ص "            },
                    new MasterDetailPage2MenuItem { Idf = 38, Title = " الزمر "        },
                    new MasterDetailPage2MenuItem { Idf = 39, Title = " غافر "         },
                    new MasterDetailPage2MenuItem { Idf = 40, Title = " فصلت "         },
                    new MasterDetailPage2MenuItem { Idf = 41, Title = " الشورى "       },
                    new MasterDetailPage2MenuItem { Idf = 42, Title = " الزخرف "       },
                    new MasterDetailPage2MenuItem { Idf = 43, Title = " الدخان "       },
                    new MasterDetailPage2MenuItem { Idf = 44, Title = " الجاثية "      },
                    new MasterDetailPage2MenuItem { Idf = 45, Title = " الأحقاف "       },
                    new MasterDetailPage2MenuItem { Idf = 46, Title = " محمد "         },
                    new MasterDetailPage2MenuItem { Idf = 47, Title = " الفتح "        },
                    new MasterDetailPage2MenuItem { Idf = 48, Title = " الحجرات "      },
                    new MasterDetailPage2MenuItem { Idf = 49, Title = " ق "             },
                    new MasterDetailPage2MenuItem { Idf = 50, Title = " الذاريات "     },
                    new MasterDetailPage2MenuItem { Idf = 51, Title = " الطور "        },
                    new MasterDetailPage2MenuItem { Idf = 52, Title = " النجم "        },
                    new MasterDetailPage2MenuItem { Idf = 53, Title = " القمر "        },
                    new MasterDetailPage2MenuItem { Idf = 54, Title = " الرحمن "       },
                    new MasterDetailPage2MenuItem { Idf = 55, Title = " الواقعة "      },
                    new MasterDetailPage2MenuItem { Idf = 56, Title = " الحديد "       },
                    new MasterDetailPage2MenuItem { Idf = 57, Title = " المجادلة "     },
                    new MasterDetailPage2MenuItem { Idf = 58, Title = " الحشر "        },
                    new MasterDetailPage2MenuItem { Idf = 59, Title = " الممتحنة "     },
                    new MasterDetailPage2MenuItem { Idf = 60, Title = " الصف "         },
                    new MasterDetailPage2MenuItem { Idf = 61, Title = " الجمعة "       },
                    new MasterDetailPage2MenuItem { Idf = 62, Title = " المنافقون "    },
                    new MasterDetailPage2MenuItem { Idf = 63, Title = " التغابن "      },
                    new MasterDetailPage2MenuItem { Idf = 64, Title = " الطلاق "        },
                    new MasterDetailPage2MenuItem { Idf = 65, Title = " التحريم "      },
                    new MasterDetailPage2MenuItem { Idf = 66, Title = " الملك "        },
                    new MasterDetailPage2MenuItem { Idf = 67, Title = " القلم "        },
                    new MasterDetailPage2MenuItem { Idf = 68, Title = " الحاقة "       },
                    new MasterDetailPage2MenuItem { Idf = 69, Title = " المعارج "      },
                    new MasterDetailPage2MenuItem { Idf = 70, Title = " نوح "          },
                    new MasterDetailPage2MenuItem { Idf = 71, Title = " الجن "         },
                    new MasterDetailPage2MenuItem { Idf = 72, Title = " المزّمِّل "       },
                    new MasterDetailPage2MenuItem { Idf = 73, Title = " المدّثر "       },
                    new MasterDetailPage2MenuItem { Idf = 74, Title = " القيامة "      },
                    new MasterDetailPage2MenuItem { Idf = 75, Title = " الإنسان "       },
                    new MasterDetailPage2MenuItem { Idf = 76, Title = " المرسلات "      },
                    new MasterDetailPage2MenuItem { Idf = 77, Title = " النبأ "        },
                    new MasterDetailPage2MenuItem { Idf = 78, Title = " النازعات "     },
                    new MasterDetailPage2MenuItem { Idf = 79, Title = " عبس "          },
                    new MasterDetailPage2MenuItem { Idf = 80, Title = " التكوير "      },
                    new MasterDetailPage2MenuItem { Idf = 81, Title = " الانفطار "      },
                    new MasterDetailPage2MenuItem { Idf = 82, Title = " المطففين "     },
                    new MasterDetailPage2MenuItem { Idf = 83, Title = " الانشقاق "      },
                    new MasterDetailPage2MenuItem { Idf = 84, Title = " البروج "       },
                    new MasterDetailPage2MenuItem { Idf = 85, Title = " الطارق "       },
                    new MasterDetailPage2MenuItem { Idf = 86, Title = " الأعلى "        },
                    new MasterDetailPage2MenuItem { Idf = 87, Title = " الغاشية "      },
                    new MasterDetailPage2MenuItem { Idf = 88, Title = " الفجر "        },
                    new MasterDetailPage2MenuItem { Idf = 99, Title = " البلد "        },
                    new MasterDetailPage2MenuItem { Idf = 90, Title = " الشمس "        },
                    new MasterDetailPage2MenuItem { Idf = 91, Title = " الليل "        },
                    new MasterDetailPage2MenuItem { Idf = 92, Title = " الضحى "        },
                    new MasterDetailPage2MenuItem { Idf = 93, Title = " الشرح "        },
                    new MasterDetailPage2MenuItem { Idf = 94, Title = " التين "        },
                    new MasterDetailPage2MenuItem { Idf = 95, Title = " العلق "        },
                    new MasterDetailPage2MenuItem { Idf = 96, Title = " القدر "        },
                    new MasterDetailPage2MenuItem { Idf = 97, Title = " البينة "       },
                    new MasterDetailPage2MenuItem { Idf = 98, Title = " الزلزلة "      },
                    new MasterDetailPage2MenuItem { Idf = 99, Title = " العاديات "     },
                    new MasterDetailPage2MenuItem { Idf = 100, Title = " القارعة "     },
                    new MasterDetailPage2MenuItem { Idf = 101, Title = " التكاثر "     },
                    new MasterDetailPage2MenuItem { Idf = 102, Title = " العصر "       },
                    new MasterDetailPage2MenuItem { Idf = 103, Title = " الهُمَزَة "      },
                    new MasterDetailPage2MenuItem { Idf = 104, Title = " الفيل "       },
                    new MasterDetailPage2MenuItem { Idf = 105, Title = " قريش "        },
                    new MasterDetailPage2MenuItem { Idf = 106, Title = " الماعون "     },
                    new MasterDetailPage2MenuItem { Idf = 107, Title = " الكوثر "      },
                    new MasterDetailPage2MenuItem { Idf = 108, Title = " الكافرون "    },
                    new MasterDetailPage2MenuItem { Idf = 109, Title = " النصر "       },
                    new MasterDetailPage2MenuItem { Idf = 110, Title = " المسد "       },
                    new MasterDetailPage2MenuItem { Idf = 111, Title = " الإخلاص "       },
                    new MasterDetailPage2MenuItem { Idf = 112, Title = " الفلق "       },
                    new MasterDetailPage2MenuItem { Idf = 113, Title = " الناس "       },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}