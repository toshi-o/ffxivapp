﻿// FFXIVAPP.Client
// MainViewModel.cs
// 
// © 2013 Ryan Wilson

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;
using FFXIVAPP.Client.Helpers;
using FFXIVAPP.Client.Models.Parse;
using FFXIVAPP.Client.Models.Parse.Events;
using FFXIVAPP.Client.Views.Parse;
using FFXIVAPP.Common.Core.Memory;
using FFXIVAPP.Common.Helpers;
using FFXIVAPP.Common.ViewModelBase;
using Microsoft.Win32;
using SmartAssembly.Attributes;

namespace FFXIVAPP.Client.ViewModels.Parse
{
    [DoNotObfuscate]
    internal sealed class MainViewModel : INotifyPropertyChanged
    {
        #region Property Bindings

        private static MainViewModel _instance;
        private ObservableCollection<ParseHistoryItem> _parseHistory;
        private dynamic _playerInfoListViewSource;
        private dynamic _monsterInfoListViewSource;
        private dynamic _overallInfoScoreCardSource;
        private dynamic _playerInfoScoreCardSource;

        public static MainViewModel Instance
        {
            get { return _instance ?? (_instance = new MainViewModel()); }
        }

        public ObservableCollection<ParseHistoryItem> ParseHistory
        {
            get
            {
                return _parseHistory ?? (_parseHistory = new ObservableCollection<ParseHistoryItem>
                {
                    new ParseHistoryItem
                    {
                        Name = "Current"
                    }
                });
            }
            set
            {
                if (_parseHistory == null)
                {
                    _parseHistory = new ObservableCollection<ParseHistoryItem>
                    {
                        new ParseHistoryItem
                        {
                            Name = "Current"
                        }
                    };
                }
                _parseHistory = value;
                RaisePropertyChanged();
            }
        }

        public dynamic PlayerInfoListViewSource
        {
            get { return _playerInfoListViewSource ?? (ParseControl.Instance.Timeline.Party); }
            set
            {
                _playerInfoListViewSource = value;
                RaisePropertyChanged();
            }
        }

        public dynamic MonsterInfoListViewSource
        {
            get { return _monsterInfoListViewSource ?? (ParseControl.Instance.Timeline.Monster); }
            set
            {
                _monsterInfoListViewSource = value;
                RaisePropertyChanged();
            }
        }

        public dynamic OverallInfoScoreCardSource
        {
            get { return _overallInfoScoreCardSource ?? (ParseControl.Instance.Timeline.Overall); }
            set
            {
                _overallInfoScoreCardSource = value;
                RaisePropertyChanged();
            }
        }

        public dynamic PlayerInfoScoreCardSource
        {
            get { return _playerInfoScoreCardSource ?? (ParseControl.Instance.Timeline.Party); }
            set
            {
                _playerInfoScoreCardSource = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region Declarations

        public ICommand RefreshSelectedCommand { get; private set; }
        public ICommand ProcessSampleCommand { get; private set; }
        public ICommand SwitchInfoViewSourceCommand { get; private set; }
        public ICommand SwitchInfoViewTypeCommand { get; private set; }
        public ICommand ResetStatsCommand { get; private set; }
        public ICommand Convert2JsonCommand { get; private set; }

        #endregion

        public MainViewModel()
        {
            RefreshSelectedCommand = new DelegateCommand(RefreshSelected);
            ProcessSampleCommand = new DelegateCommand(ProcessSample);
            SwitchInfoViewSourceCommand = new DelegateCommand(SwitchInfoViewSource);
            SwitchInfoViewTypeCommand = new DelegateCommand(SwitchInfoViewType);
            ResetStatsCommand = new DelegateCommand(ResetStats);
            Convert2JsonCommand = new DelegateCommand(Convert2Json);
        }

        #region Loading Functions

        #endregion

        #region Utility Functions

        #endregion

        #region Command Bindings

        private void RefreshSelected()
        {
            DispatcherHelper.Invoke(delegate
            {
                try
                {
                    var index = MainView.View.PlayerInfoListView.SelectedIndex;
                    MainView.View.PlayerInfoListView.SelectedIndex = -1;
                    MainView.View.PlayerInfoListView.SelectedIndex = index;
                }
                catch (Exception)
                {
                }
                try
                {
                    var index = MainView.View.MonsterInfoListView.SelectedIndex;
                    MainView.View.MonsterInfoListView.SelectedIndex = -1;
                    MainView.View.MonsterInfoListView.SelectedIndex = index;
                }
                catch (Exception)
                {
                }
            });
        }

        private static void ProcessSample()
        {
            if (Constants.IsOpen)
            {
                var title = AppViewModel.Instance.Locale["app_WarningMessage"];
                var message = "Game is open. Please close before choosing a file.";
                MessageBoxHelper.ShowMessageAsync(title, message);
                return;
            }
            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Path.Combine(Common.Constants.CachePath, "Logs"),
                Multiselect = false,
                Filter = "XML Files (*.xml)|*.xml"
            };
            openFileDialog.FileOk += delegate
            {
                var count = 0;
                var sampleXml = XDocument.Load(openFileDialog.FileName);
                var items = new Dictionary<int, string[]>();
                foreach (var xElement in sampleXml.Descendants()
                                                  .Elements("Entry"))
                {
                    var xKey = (string) xElement.Attribute("Key");
                    var xBytes = (string) xElement.Element("Bytes");
                    var xLine = (string) xElement.Element("Line");
                    var xTimeStamp = (string) xElement.Element("TimeStamp");
                    if (String.IsNullOrWhiteSpace(xKey) || String.IsNullOrWhiteSpace(xLine))
                    {
                        continue;
                    }
                    items.Add(count, new[]
                    {
                        xKey, xLine, xTimeStamp, xBytes
                    });
                    ++count;
                }
                Func<bool> func = delegate
                {
                    foreach (var item in items)
                    {
                        var chatLogEntry = new ChatLogEntry
                        {
                            Code = item.Value[0],
                            Line = item.Value[1].Replace("  ", " ")
                        };
                        EventParser.Instance.ParseAndPublish(chatLogEntry);
                    }
                    return true;
                };
                func.BeginInvoke(null, null);
            };
            openFileDialog.ShowDialog();
        }

        private void SwitchInfoViewSource()
        {
            try
            {
                var index = MainView.View.InfoViewSource.SelectedIndex;
                switch (index)
                {
                    case 0:
                        PlayerInfoListViewSource = null;
                        MonsterInfoListViewSource = null;
                        OverallInfoScoreCardSource = null;
                        PlayerInfoScoreCardSource = null;
                        break;
                    default:
                        PlayerInfoListViewSource = ParseHistory[index].HistoryControl.Timeline.Party;
                        MonsterInfoListViewSource = ParseHistory[index].HistoryControl.Timeline.Monster;
                        OverallInfoScoreCardSource = ParseHistory[index].HistoryControl.Timeline.Overall;
                        PlayerInfoScoreCardSource = ParseHistory[index].HistoryControl.Timeline.Party;
                        break;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private static void SwitchInfoViewType()
        {
            try
            {
                var index = MainView.View.InfoViewType.SelectedIndex;
                switch (MainView.View.InfoViewType.SelectedIndex)
                {
                    case 0:
                        MainView.View.PlayerInfoListView.Visibility = Visibility.Collapsed;
                        MainView.View.MonsterInfoListView.Visibility = Visibility.Collapsed;
                        MainView.View.RefreshSelectedButton.Visibility = Visibility.Collapsed;
                        break;
                    case 1:
                        MainView.View.PlayerInfoListView.Visibility = Visibility.Visible;
                        MainView.View.MonsterInfoListView.Visibility = Visibility.Collapsed;
                        MainView.View.RefreshSelectedButton.Visibility = Visibility.Visible;
                        break;
                    case 2:
                        MainView.View.PlayerInfoListView.Visibility = Visibility.Collapsed;
                        MainView.View.MonsterInfoListView.Visibility = Visibility.Collapsed;
                        MainView.View.RefreshSelectedButton.Visibility = Visibility.Collapsed;
                        break;
                    case 3:
                        MainView.View.PlayerInfoListView.Visibility = Visibility.Collapsed;
                        MainView.View.MonsterInfoListView.Visibility = Visibility.Visible;
                        MainView.View.RefreshSelectedButton.Visibility = Visibility.Visible;
                        break;
                    case 4:
                        MainView.View.PlayerInfoListView.Visibility = Visibility.Collapsed;
                        MainView.View.MonsterInfoListView.Visibility = Visibility.Collapsed;
                        MainView.View.RefreshSelectedButton.Visibility = Visibility.Collapsed;
                        break;
                }
                MainView.View.InfoViewResults.SelectedIndex = index;
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// </summary>
        private static void ResetStats()
        {
            var title = AppViewModel.Instance.Locale["app_WarningMessage"];
            var message = AppViewModel.Instance.Locale["parse_ResetStatsMessage"];
            MessageBoxHelper.ShowMessageAsync(title, message, delegate { ParseControl.Instance.Reset(); }, delegate { });
        }

        private static void Convert2Json()
        {
            #region Generate Overall-Player-Monster

            dynamic overallStats = new Dictionary<string, object>();
            dynamic playerStats = new Dictionary<string, object>();
            dynamic monsterStats = new Dictionary<string, object>();
            overallStats.Add("Stats", ParseControl.Instance.Timeline.Overall.Stats.ToDictionary(s => s.Name, s => s.Value));
            var partyTimeline = ParseControl.Instance.Timeline.Party;
            var playerNames = partyTimeline.Select(p => p.Name)
                                           .ToList();
            foreach (var playerName in playerNames)
            {
                var player = partyTimeline.GetGroup(playerName);
                playerStats.Add(playerName, new Dictionary<string, object>
                {
                    {
                        "Stats", new Dictionary<string, object>()
                    },
                    {
                        "Abilities", new Dictionary<string, object>()
                    },
                    {
                        "Monsters", new Dictionary<string, object>()
                    },
                    {
                        "Healing", new Dictionary<string, object>()
                    },
                    {
                        "Players", new Dictionary<string, object>()
                    },
                    {
                        "Damage", new Dictionary<string, object>()
                    }
                });
                playerStats[playerName]["Stats"] = player.Stats.ToDictionary(s => s.Name, s => s.Value);
                var playerAbilities = player.GetGroup("Abilities");
                foreach (var playerAbility in playerAbilities)
                {
                    playerStats[playerName]["Abilities"].Add(playerAbility.Name, playerAbility.Stats.ToDictionary(s => s.Name, s => s.Value));
                }
                var playerMonsters = player.GetGroup("Monsters");
                foreach (var playerMonster in playerMonsters)
                {
                    playerStats[playerName]["Monsters"].Add(playerMonster.Name, new Dictionary<string, object>
                    {
                        {
                            "Stats", playerMonster.Stats.ToDictionary(s => s.Name, s => s.Value)
                        },
                        {
                            "Abilities", playerMonster.GetGroup("Abilities")
                                                      .ToDictionary(a => a.Name, a => a.Stats.ToDictionary(s => s.Name, s => s.Value))
                        }
                    });
                }
                var playerHealings = player.GetGroup("Healing");
                foreach (var playerHealing in playerHealings)
                {
                    playerStats[playerName]["Healing"].Add(playerHealing.Name, playerHealing.Stats.ToDictionary(s => s.Name, s => s.Value));
                }
                var playerPlayers = player.GetGroup("Players");
                foreach (var playerPlayer in playerPlayers)
                {
                    playerStats[playerName]["Players"].Add(playerPlayer.Name, new Dictionary<string, object>
                    {
                        {
                            "Stats", playerPlayer.Stats.ToDictionary(s => s.Name, s => s.Value)
                        },
                        {
                            "Abilities", playerPlayer.GetGroup("Abilities")
                                                     .ToDictionary(a => a.Name, a => a.Stats.ToDictionary(s => s.Name, s => s.Value))
                        }
                    });
                }
                var playerDamages = player.GetGroup("Damage");
                foreach (var playerDamage in playerDamages)
                {
                    playerStats[playerName]["Damage"].Add(playerDamage.Name, new Dictionary<string, object>
                    {
                        {
                            "Stats", playerDamage.Stats.ToDictionary(s => s.Name, s => s.Value)
                        },
                        {
                            "Abilities", playerDamage.GetGroup("Abilities")
                                                     .ToDictionary(a => a.Name, a => a.Stats.ToDictionary(s => s.Name, s => s.Value))
                        }
                    });
                }
            }
            var monsterTimeline = ParseControl.Instance.Timeline.Monster;
            var monsterNames = monsterTimeline.Select(p => p.Name)
                                              .ToList();
            foreach (var monsterName in monsterNames)
            {
                var monster = monsterTimeline.GetGroup(monsterName);
                monsterStats.Add(monsterName, new Dictionary<string, object>
                {
                    {
                        "Stats", new Dictionary<string, object>()
                    },
                    {
                        "Abilities", new Dictionary<string, object>()
                    },
                    {
                        "Drops", new Dictionary<string, object>()
                    }
                });
                monsterStats[monsterName]["Stats"] = monster.Stats.ToDictionary(s => s.Name, s => s.Value);
                var monsterAbilities = monster.GetGroup("Abilities");
                foreach (var monsterAbility in monsterAbilities)
                {
                    monsterStats[monsterName]["Abilities"].Add(monsterAbility.Name, monsterAbility.Stats.ToDictionary(s => s.Name, s => s.Value));
                }
                var monsterDrops = monster.GetGroup("Drops");
                foreach (var monsterDrop in monsterDrops)
                {
                    monsterStats[monsterName]["Drops"].Add(monsterDrop.Name, monsterDrop.Stats.ToDictionary(s => s.Name, s => s.Value));
                }
            }
            dynamic results = new Dictionary<string, object>
            {
                {
                    "Overall", overallStats
                },
                {
                    "Player", playerStats
                },
                {
                    "Monster", monsterStats
                }
            };

            #endregion

            //Clipboard.SetText(JsonConvert.SerializeObject(results));
        }

        #endregion

        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(caller));
        }

        #endregion
    }
}