# HexagonalStructureSample
以 WPF 結合 Host、DI、六角架構，顯示資料。

MVVM (Model-View-ViewModel) 是一種用於開發軟體應用程式的架構模式，而六角架構 (Hexagonal Architecture) 則是一種用於設計和組織應用程式的架構風格。

MVVM
是一種在用戶介面層次 (UI Layer) 上的架構模式，它將應用程式的介面與邏輯分離。它通常涉及到建立 ViewModel 來處理 UI 相關的邏輯和資料綁定，以及使用資料模型 (Model) 來表示數據。

六角架構
是一種更高層次的架構風格，強調將應用程式核心 (Core) 與外部組件解耦。它的目標是提供一個可擴展且可測試的應用程式架構，並將業務邏輯從框架和基礎設施解耦。

MVVM 可以在六角架構中作為 UI Layer 的一部分。可以將 MVVM 的 ViewModel 視為六角架構中的「Primary Adapter」，它負責將 UI 事件轉發給應用程式的核心 (Core)，並將核心處理的結果返回給 View。

在整合 MVVM 和六角架構時，可以將六角架構的 "Core" 當作 MVVM 中的 Model，並使用 ViewModel 來處理 UI 相關的邏輯和資料綁定。你還可以使用六角架構的思維方式來設計和組織你的應用程式的業務邏輯，並將其解耦。
