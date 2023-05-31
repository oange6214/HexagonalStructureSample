# HexagonalStructureSample


本解決方案建立 4 個專案，分別是：
- BISP.DomainLayer：這是專案的核心，包含所有的業務邏輯和實體（Entities）。
- BISP.ApplicationLayer：對應六角架構中的內側埠（Inner Ports）。它定義了應用程式的使用案例，並直接與 Domain 層交互。
- BISP.InfrastructureLayer：這個層級對應於六角架構中的適配器（Adapters）。它包含了所有與外部世界的交互，例如資料庫存取、檔案系統操作、網路請求等。
- BISP.UI：這是應用程式的使用者介面（User interface）。會使用 MVVM 作為 UI 架構。


專案類型：
- BISP.DomainLayer：Class Library
- BISP.ApplicationLayer：Class Library
- BISP.InfrastructureLayer：Class Library
- BISP.UI：WPF Application


專案依賴示意圖：

- UI ["WPF MVVM"]
    - UI -->|Use Cases| A
- A ["Application"]
    - A -->|Business Logic| D
    - A -->|External Interactions| I
- D ["Domain"]
- I ["Infrastructure"]
    - I -->|Business Logic| D


專案使用套件：
- BISP.UI
    - Microsoft.Extensions.Hosting
    - Microsoft.Extensions.DependencyInjection
- BISP.InfrastructureLayer
    - Microsoft.EntityFrameworkCore
    - Microsoft.EntityFrameworkCore.SqlServer
    - Microsoft.EntityFrameworkCore.Design
    - Microsoft.EntityFrameworkCore.Tools


MVVM (Model-View-ViewModel) 是一種用於開發軟體應用程式的架構模式，而六角架構 (Hexagonal Architecture) 則是一種用於設計和組織應用程式的架構風格。

MVVM（Model-View-ViewModel）
是一種在用戶介面層次 (UI Layer) 上的架構模式，它將應用程式的介面與邏輯分離。它通常涉及到建立 ViewModel 來處理 UI 相關的邏輯和資料綁定，以及使用資料模型 (Model) 來表示數據。

六角架構（Hexagonal Architecuture）
是一種更高層次的架構風格，強調將應用程式核心 (Core) 與外部組件解耦。它的目標是提供一個可擴展且可測試的應用程式架構，並將業務邏輯從框架和基礎設施解耦。

MVVM 可以在六角架構中作為 UI Layer 的一部分。可以將 MVVM 的 ViewModel 視為六角架構中的「Primary Adapter」，它負責將 UI 事件轉發給應用程式的核心 (Core)，並將核心處理的結果返回給 View。

在整合 MVVM 和六角架構時，可以將六角架構的 "Core" 當作 MVVM 中的 Model，並使用 ViewModel 來處理 UI 相關的邏輯和資料綁定。你還可以使用六角架構的思維方式來設計和組織你的應用程式的業務邏輯，並將其解耦。
