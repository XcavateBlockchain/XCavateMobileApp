﻿using System;
using System.Collections.ObjectModel;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Net.Mime.MediaTypeNames;

namespace PlutoWallet.Constants
{
    public class Endpoints
    {
        public static List<Endpoint> GetAllEndpoints => GetEndpointDictionary.Values.ToList();

        public static readonly ReadOnlyDictionary<string, string> HashToKey = new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
        {
            { "0x91b171bb158e2d3848fa23a9f1c25182fb8e20313b2c1eb49219da7a70ce90c3", "polkadot" },
            { "0xb0a8d493285c2df73290dfb7e61f870f17b41801197a149ca93654499ea3dafe", "kusama" },
            { "0xfe58ea77779b7abda7da4ec526d14db9b1e9cd40a217c34892af80a9b332b76d", "moonbeam" },
            { "0x9eb76c5184c4ab8679d2d5d819fdf90b9c001403e9e17da2e14b6d8aec4029c6", "astar" },
            { "0xe358eb1d11b31255a286c12e44fe6780b7edb171d657905a97e39f71d9c6c3ee", "ajuna" },
            { "0x35a06bfec2edf0ff4be89a6428ccd9ff5bd0167d618c5a0d4341f9600a458d14", "bajun" },
            { "0xf3c7ad88f6a80f366c4be216691411ef0622e8b809b1046ea297ef106058d4eb", "manta" },
            { "0xe143f23803ac50e8f6f8e62695d1ce9e4e1d68aa36c1cd2cfd15340213f3423e", "westend" },
            { "0x48239ef607d7928874027a43a67689209727dfb3d3dc5e5b03a39bdc2eda771a", "statemine" },
            { "0x68d56f15f85d3136970ec16946040bc1752654e906147f7e43e9d539d7c3de2f", "statemint" },
            { "0x84322d9cddbf35088f1e54e9a85c967a41a56a4f43445768125e61af166c7d31", "unique" },
            { "0xcd4d732201ebe5d6b014edda071c4203e16867305332301dc8d092044b28e554", "quartz" },
            { "0xc87870ef90a438d574b8e320f17db372c50f62beb52e479c8ff6ee5b460670b9", "opal" },
            { "0xddb89973361a170839f80f152d2e9e38a376a5a7eccefcade763f46a8e567019", "shibuya" },
            { "0x91bc6e169807aaa54802737e1c504b2577d4fafedd5a02c10293b1cd60e39527", "moonbasealpha" },
            { "0x05d5279c52c484cc80396535a316add7d47b1c5b9e0398dd1f584149341460c5", "azerotestnet" },
            { "0xfc41b9bd8ef8fe53d58c7ea67c794c7ec9a73daf05e6d54b14ff6342c99ba64c", "acala" },
            { "0xa85cfb9b9fd4d622a5b28289a02347af987d8f73fa3108450e2b4a11c1ce5755", "basilisk" },
            { "0xafdc188f45c71dacbaa0b62e16a91f726c7b8699a9748cdf715459de6b7f366d", "hydradx" },
            { "0x401a1f9dca3da46f5c4091016c8a2f26dcea05865116b286f60f668207d1474b", "moonriver" },
            { "0x262e1b2ad728475fd6fe88e62d34c200abe6fd693931ddad144059b1eb884e5b", "bifrost" },
        });

        public static readonly ReadOnlyDictionary<string, Endpoint> GetEndpointDictionary = new ReadOnlyDictionary<string, Endpoint>(new Dictionary<string, Endpoint>()
        {
            { "polkadot", new Endpoint
            {
                Name = "Polkadot",
                Key = "polkadot",
                URLs = new string[5] { "wss://polkadot-rpc.dwellir.com", "wss://polkadot-public-rpc.blockops.network/ws", "wss://rpc.ibp.network/polkadot", "wss://polkadot.api.onfinality.io/public-ws", "wss://polkadot.public.curie.radiumblock.co/ws" },
                Icon = "polkadot.png",
                DarkIcon = "polkadot.png",
                CalamarChainName = "polkadot",
                SubSquareChainName = "polkadot",
                Unit = "DOT",
                Decimals = 10,
                SS58Prefix = 0,
                ChainType = ChainType.Substrate,
            } },
            { "kusama", new Endpoint
            {
                Name = "Kusama",
                Key = "kusama",
                URLs = new string[4] { "wss://kusama-rpc.dwellir.com", "wss://rpc.ibp.network/kusama", "wss://kusama.public.curie.radiumblock.co/ws", "wss://kusama.api.onfinality.io/public-ws" },
                Icon = "kusama.png",
                DarkIcon = "kusamawhite.png",
                CalamarChainName = "kusama",
                SubSquareChainName = "kusama",
                Unit = "KSM",
                Decimals = 12,
                SS58Prefix = 2,
                ChainType = ChainType.Substrate,
            } },
            { "moonbeam", new Endpoint
            {
                Name = "Moonbeam",
                Key = "moonbeam",
                URLs =  new string[3] { "wss://wss.api.moonbeam.network", "wss://moonbeam.unitedbloc.com", "wss://moonbeam.api.onfinality.io/public-ws" },
                Icon = "moonbeam.png",
                DarkIcon = "moonbeam.png",
                CalamarChainName = "moonbeam",
                Unit = "GLMR",
                Decimals = 18,
                SS58Prefix = 1284,
                ChainType = ChainType.Ethereum,
            } },
            { "astar", new Endpoint
            {
                Name = "Astar",
                Key = "astar",
                URLs =  new string[2] { "wss://astar-rpc.dwellir.com", "wss://astar.public.blastapi.io" },
                Icon = "astar.png",
                DarkIcon = "astar.png",
                CalamarChainName = "astar",
                Unit = "ASTR",
                Decimals = 18,
                SS58Prefix = 5,
                ChainType = ChainType.Substrate,
            } },
            { "ajuna", new Endpoint
            {
                Name = "Ajuna",
                Key = "ajuna",
                URLs =  new string[1] { "wss://ajuna.api.onfinality.io/public-ws" /*"wss://rpc-parachain.ajuna.network"*/ },
                Icon = "ajuna.png",
                DarkIcon = "ajuna.png",
                Unit = "AJUN",
                Decimals = 12,
                SS58Prefix = 1328,
                ChainType = ChainType.Substrate,
            } },
            { "bajun", new Endpoint
            {
                Name = "Bajun",
                Key = "bajun",
                URLs =  new string[2] { "wss://rpc-parachain.bajun.network", "wss://bajun.api.onfinality.io/public-ws" /*"wss://bajun.public.curie.radiumblock.co/ws"*/  },
                Icon = "bajun.png",
                DarkIcon = "bajun.png",
                Unit = "BAJU",
                CalamarChainName = "bajun",
                Decimals = 12,
                SS58Prefix = 1337,
                ChainType = ChainType.Substrate,
            } },
            { "manta", new Endpoint
            {
                Name = "Manta parachain",
                Key = "manta",
                URLs =  new string[1] { "wss://ws.manta.systems" },
                Icon = "manta.png",
                DarkIcon = "manta.png",
                Unit = "MANTA",
                Decimals = 18,
                SS58Prefix = 77,
                ChainType = ChainType.Substrate,
            } },
            { "westend", new Endpoint
            {
                Name = "Westend",
                Key = "westend",
                URLs =  new string[2] { "wss://westend-rpc.dwellir.com", "wss://westend.api.onfinality.io/public-ws" },
                Icon = "westend.png",
                DarkIcon = "westend.png",
                Unit = "WND",
                Decimals = 12,
                SS58Prefix = 42,
                ChainType = ChainType.Substrate,
            } },
            /*{ "rococo", new Endpoint
            {
                Name = "Rococo",
                Key = "rococo",
                URLs = "wss://rococo-rpc.polkadot.io",
                Icon = "rococo.png",
                DarkIcon = "rococo.png",
                CalamarChainName = "rococo",
                Unit = "ROC",
                Decimals = 12,
                SS58Prefix = 42,
                ChainType = ChainType.Substrate,
            } },*/
            /*{ "rockmine", new Endpoint
            {
                Name = "Rockmine",
                Key = "rockmine",
                URLs = "wss://rococo-rockmine-rpc.polkadot.io",
                Icon = "statemint.png",
                DarkIcon = "statemint.png",
                Unit = "ROC",
                Decimals = 12,
                SS58Prefix = 2,
                ChainType = ChainType.Substrate,
                SupportsNfts = true,
            } },*/
            /*{ "bajunrococo", new Endpoint
            {
                Name = "Bajun rococo",
                Key = "bajunrococo",
                URLs = "wss://rpc-rococo.bajun.network",
                Icon = "bajun.png",
                DarkIcon = "bajun.png",
                Unit = "BAJU",
                Decimals = 12,
                SS58Prefix = 1337,
                ChainType = ChainType.Substrate,
            } },*/
            { "statemine", new Endpoint
            {
                Name = "Kusama Asset Hub",
                Key = "statemine",
                URLs =  new string[4] { "wss://statemine-rpc.dwellir.com", "wss://rpc-asset-hub-kusama.luckyfriday.io", "wss://ksm-rpc.stakeworld.io/assethub", "wss://statemine-rpc-tn.dwellir.com" },
                Icon = "statemint.png",
                DarkIcon = "statemint.png",
                Unit = "KSM",
                Decimals = 12,
                SS58Prefix = 2,
                ChainType = ChainType.Substrate,
                SupportsNfts = true,
                CalamarChainName = "statemine"
            } },
            { "statemint", new Endpoint {
                Name = "Polkadot Asset Hub",
                Key = "statemint",
                URLs =  new string[4] { "wss://statemint-rpc.dwellir.com", "wss://statemint-rpc-tn.dwellir.com", "wss://statemint.api.onfinality.io/public-ws", "wss://dot-rpc.stakeworld.io/assethub" },
                Icon = "statemint.png",
                DarkIcon = "statemint.png",
                Unit = "DOT",
                Decimals = 10,
                SS58Prefix = 0,
                ChainType = ChainType.Substrate,
                SupportsNfts = true,
                CalamarChainName = "statemint"
            } },
            { "unique", new Endpoint
            {
                Name = "Unique",
                Key = "unique",
                URLs =  new string[4] { "wss://ws.unique.network", "wss://eu-ws.unique.network", "wss://us-ws.unique.network", "wss://unique-rpc.dwellir.com" },
                Icon = "unique.png",
                DarkIcon = "unique.png",
                CalamarChainName = "unique",
                Unit = "UNQ",
                Decimals = 18,
                SS58Prefix = 7391,
                ChainType = ChainType.Substrate,
            } },
            { "quartz", new Endpoint
            {
                Name = "QUARTZ by UNIQUE ",
                Key = "quartz",
                URLs =  new string[3] { "wss://eu-ws-quartz.unique.network", "wss://ws-quartz.unique.network", "wss://quartz-rpc.dwellir.com" },
                Icon = "quartz.png",
                DarkIcon = "quartz.png",
                CalamarChainName = "quartz",
                Unit = "QTZ",
                Decimals = 18,
                SS58Prefix = 255,
                ChainType = ChainType.Substrate,
            } },
            { "opal", new Endpoint
            {
                Name = "OPAL by UNIQUE",
                Key = "opal",
                URLs =  new string[2] { "wss://eu-ws-opal.unique.network", "wss://ws-opal.unique.network" },
                Icon = "opal.png",
                DarkIcon = "opal.png",
                CalamarChainName = "opal",
                Unit = "OPL",
                Decimals = 18,
                SS58Prefix = 42,
                ChainType = ChainType.Substrate,
            } },
            { "shibuya", new Endpoint
            {
                Name = "Shibuya",
                Key = "shibuya",
                URLs =  new string[2] { "wss://shibuya-rpc.dwellir.com", "wss://rpc.shibuya.astar.network" },
                Icon = "shibuya.png",
                DarkIcon = "shibuya.png",
                CalamarChainName = "shibuya",
                Unit = "SBY",
                Decimals = 18,
                SS58Prefix = 5,
                ChainType = ChainType.Substrate,
            } },
            { "moonbasealpha", new Endpoint
            {
                Name = "Moonbase Alpha",
                Key = "moonbasealpha",
                URLs =  new string[3] { "wss://wss.api.moonbase.moonbeam.network", "wss://moonbeam-alpha.api.onfinality.io/public-ws", "wss://moonbase-rpc.dwellir.com" },
                Icon = "moonbase.png",
                DarkIcon = "moonbase.png",
                CalamarChainName = "moonbase",
                Unit = "DEV",
                Decimals = 18,
                SS58Prefix = 1287,
                ChainType = ChainType.Ethereum,
            } },
            { "azerotestnet", new Endpoint
            {
                Name = "Aleph Zero Testnet",
                Key = "azerotestnet",
                URLs =  new string[2] { "wss://ws.test.azero.dev", "wss://aleph-zero-testnet-rpc.dwellir.com" },
                Icon = "alephzerotestnet.png",
                DarkIcon = "alephzerotestnet.png",
                Unit = "TZERO",
                CalamarChainName = "aleph-zero-testnet",
                Decimals = 12,
                SS58Prefix = 42,
                ChainType = ChainType.Substrate,
            } },
            { "acala", new Endpoint
            {
                Name = "Acala",
                Key = "acala",
                URLs =  new string[3] { "wss://acala-rpc-3.aca-api.network/ws", "wss://acala-rpc.dwellir.com", "wss://acala-polkadot.api.onfinality.io/public-ws" },
                Icon = "acala.png",
                DarkIcon = "acala.png",
                CalamarChainName = "acala",
                Unit = "ACA",
                Decimals = 12,
                SS58Prefix = 10,
                ChainType = ChainType.Substrate,
            } },
            { "basilisk", new Endpoint
            {
                Name = "Basilisk",
                Key = "basilisk",
                URLs =  new string[2] { "wss://rpc.basilisk.cloud", "wss://basilisk-rpc.dwellir.com" },
                Icon = "basilisk.png",
                DarkIcon = "basilisk.png",
                Unit = "BSX",
                SS58Prefix = 10041,
                Decimals = 12,
                ChainType = ChainType.Substrate,
            } },
            { "hydradx", new Endpoint
            {
                Name = "HydraDX",
                Key = "hydradx",
                URLs =  new string[2] { "wss://rpc.hydradx.cloud", "wss://hydradx-rpc.dwellir.com" },
                Icon = "hydradxomnipool.png",
                DarkIcon = "hydradxomnipool.png",
                Unit = "HDX",
                SS58Prefix = 63,
                Decimals = 12,
                ChainType = ChainType.Substrate,
                CalamarChainName = "hydradx",
                SupportsNfts = true
            } },
            /*{
                "xcavate", new Endpoint
                {
                    Name = "XCavate",
                    Key = "xcavate",
                    URLs =  new string[2] { "wss://fraa-dancebox-3031-rpc.a.dancebox.tanssi.network" },
                    Icon = "xcavate.png",
                    DarkIcon = "xcavate.png",
                    Unit = "XCAV",
                    SS58Prefix = 42,
                    Decimals = 12,
                    ChainType = ChainType.Substrate,
                    SupportsNfts = true,
                }
            },*/
            {
                "moonriver", new Endpoint
                {
                    Name = "Moonriver",
                    Key = "moonriver",
                    URLs =  new string[2] { "wss://wss.api.moonriver.moonbeam.network", "wss://moonriver-rpc.dwellir.com" },
                    Icon = "moonriver.png",
                    DarkIcon = "moonriver.png",
                    Unit = "MOVR",
                    SS58Prefix = 1285,
                    Decimals = 18,
                    ChainType = ChainType.Substrate,
                }
            },
            {
                "bifrost", new Endpoint
                {
                    Name = "Bifrost",
                    Key = "bifrost",
                    URLs =  new string[2] { "wss://bifrost-polkadot.api.onfinality.io/public-ws", "wss://bifrost-rpc.liebi.com/ws" /*"wss://bifrost-rpc.dwellir.com"*/ },
                    Icon = "bifrost.png",
                    DarkIcon = "bifrost.png",
                    Unit = "BNC",
                    SS58Prefix = 6,
                    Decimals = 12,
                    ChainType = ChainType.Substrate,
                }
            },
            { "local", new Endpoint
            {
                Name = "(Local) ws://127.0.0.1:9944",
                Key = "local",
                URLs =  new string[1] { "ws://127.0.0.1:9944" },
                Icon = "substrate.png",
                DarkIcon = "substrate.png",
                Unit = "",
                Decimals = 0,
                SS58Prefix = 42,
                ChainType = ChainType.Substrate,
            } }
        });
    }

    public enum ChainType
    {
        Substrate,
        Ethereum,
        Other,
    }

	public class Endpoint
	{
        public string Name { get; set; }
        public string[] URLs { get; set; }
		public string Icon { get; set; }
        public string DarkIcon { get; set; }
		public string CalamarChainName { get; set; }
        public string SubSquareChainName { get; set; }
        public string Key { get; set; }

        // Symbol and Unit are interchangeable names.
		public string Unit { get; set; }
		public int Decimals { get; set; }
		public short SS58Prefix { get; set; }
        public ChainType ChainType { get; set; }
        public bool SupportsNfts { get; set; } = false;


        /*public Endpoint Clone()
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, this);
                ms.Position = 0;
                return (Endpoint)formatter.Deserialize(ms);
            }
        }*/

        public Endpoint Clone()
        {
            return new Endpoint
            {
                Name = this.Name,
                URLs = this.URLs,
                Icon = this.Icon,
                DarkIcon = this.DarkIcon,
                CalamarChainName = this.CalamarChainName,
                SubSquareChainName = this.SubSquareChainName,
                Key = this.Key,
                Unit = this.Unit,
                Decimals = this.Decimals,
                SS58Prefix = this.SS58Prefix,
                ChainType = this.ChainType,
                SupportsNfts = this.SupportsNfts,
            };
        }
    }
}

