﻿using System;
using static System.Net.Mime.MediaTypeNames;

namespace PlutoWallet.Constants
{
    public class Endpoints
    {
        public static List<Endpoint> GetAllEndpoints => GetEndpointDictionary.Values.ToList();

        public static readonly Dictionary<string, Endpoint> GetEndpointDictionary = new Dictionary<string, Endpoint>()
        {
            { "polkadot", new Endpoint
            {
                Name = "Polkadot",
                Key = "polkadot",
                URLs = new string[4] { "wss://polkadot-rpc.dwellir.com", "wss://1rpc.io/dot", "wss://polkadot.api.onfinality.io/public-ws", "wss://polkadot.public.curie.radiumblock.co/ws" },
                Icon = "polkadot.png",
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
                URLs = new string[3] { "wss://kusama-rpc.dwellir.com", "wss://rpc.ibp.network/kusama", "wss://kusama.api.onfinality.io/public-ws" },
                Icon = "kusama.png",
                DarkIcon = "kusama.png",
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
                URLs =  new string[2] { "wss://wss.api.moonbeam.network", "wss://moonbeam.api.onfinality.io/public-ws" },
                Icon = "moonbeam.png",
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
                URLs =  new string[2] { "wss://astar-rpc.dwellir.com", "wss://astar.api.onfinality.io/public-ws" },
                Icon = "astar.png",
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
                URLs =  new string[2] { "wss://ajuna.api.onfinality.io/public-ws", "wss://rpc-parachain.ajuna.network" },
                Icon = "ajuna.png",
                Unit = "AJUN",
                Decimals = 12,
                SS58Prefix = 1328,
                ChainType = ChainType.Substrate,
            } },
            { "bajun", new Endpoint
            {
                Name = "Bajun",
                Key = "bajun",
                URLs =  new string[2] { "wss://rpc-parachain.bajun.network", "wss://bajun.api.onfinality.io/public-ws" },
                Icon = "bajun.png",
                Unit = "BAJU",
                CalamarChainName = "bajun",
                Decimals = 12,
                SS58Prefix = 1337,
                ChainType = ChainType.Substrate,
            } },
            { "manta", new Endpoint
            {
                Name = "Manta",
                Key = "manta",
                URLs =  new string[1] { "wss://ws.manta.systems" },
                Icon = "manta.png",
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
                Unit = "BAJU",
                Decimals = 12,
                SS58Prefix = 1337,
                ChainType = ChainType.Substrate,
            } },*/
            { "statemine", new Endpoint
            {
                Name = "Kusama Asset Hub",
                Key = "statemine",
                URLs =  new string[4] { "wss://statemine-rpc.dwellir.com", "wss://kusama.api.onfinality.io/public-ws", "wss://1rpc.io/ksm", "wss://kusama.public.curie.radiumblock.co/ws" },
                Icon = "statemint.png",
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
                CalamarChainName = "unique",
                Unit = "UNQ",
                Decimals = 18,
                SS58Prefix = 7391,
                ChainType = ChainType.Substrate,
            } },
            { "quartz", new Endpoint
            {
                Name = "Quartz",
                Key = "quartz",
                URLs =  new string[3] { "wss://eu-ws-quartz.unique.network", "wss://ws-quartz.unique.network", "wss://quartz-rpc.dwellir.com" },
                Icon = "quartz.png",
                CalamarChainName = "quartz",
                Unit = "QTZ",
                Decimals = 18,
                SS58Prefix = 255,
                ChainType = ChainType.Substrate,
            } },
            { "opal", new Endpoint
            {
                Name = "Opal",
                Key = "opal",
                URLs =  new string[2] { "wss://eu-ws-opal.unique.network", "wss://ws-opal.unique.network" },
                Icon = "opal.png",
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
                    URLs =  new string[2] { "wss://bifrost-polkadot.api.onfinality.io/public-ws", "wss://bifrost-rpc.dwellir.com" },
                    Icon = "bifrost.png",
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
                Unit = "",
                Decimals = 0,
                SS58Prefix = 42,
                ChainType = ChainType.Substrate,
            } }
        };
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
    }
}

