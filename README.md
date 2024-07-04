# LearningBlazorDotNet

Routable and Non-Routable Components in Blazor
In Blazor, components can be categorized as routable or non-routable based on whether they can be navigated to directly via a URL. Understanding the difference between these two types of components is crucial for designing and organizing your Blazor application.

Routable Components
Routable components are components that can be reached via a URL. These components are typically used to represent different pages or views in your application. They are defined with a specific route, and Blazor's router uses these routes to navigate between components.

Key Characteristics:
Route Attribute: Routable components must have a @page directive at the top of the component file, specifying the URL pattern for the component.

razor
@page "/example"

<h3>Example Component</h3>
In this example, the ExampleComponent can be accessed via the URL /example.

Navigation: Users can navigate to these components using hyperlinks or browser navigation (back/forward buttons).

Direct URL Access: These components can be directly accessed by entering the corresponding URL in the browser's address bar.

Routing Configuration: Routable components are typically configured in the Blazor application's router, defined in the App.razor file.

razor
<Router AppAssembly="@typeof(Program).Assembly">
<Found Context="routeData">
<RouteView RouteData="@routeData" DefaultLayout="@typeof(MainLayout)" />
<FocusOnNavigate RouteData="@routeData" Selector="h1" />
</Found>
<NotFound>
<PageTitle>Not Found</PageTitle>

<h3>Sorry, there's nothing at this address.</h3>
</NotFound>
</Router>
Non-Routable Components
Non-routable components are components that cannot be reached directly via a URL. These components are typically used as child components within other routable or non-routable components and are intended to be reused throughout the application.

Key Characteristics:
No Route Attribute: Non-routable components do not have a @page directive.

razor

<h3>Reusable Component</h3>
Used as Child Components: These components are designed to be included within other components.

razor
<ExampleComponent />
No Direct URL Access: Users cannot navigate to these components directly by entering a URL.

Reusability: Non-routable components are often used to encapsulate reusable functionality or UI elements that can be used in multiple places within the application.

Example of Using Routable and Non-Routable Components
Routable Component (ExampleComponent.razor)
razor

@page "/example"

<h3>Example Component</h3>
<ReusableComponent />
Non-Routable Component (ReusableComponent.razor)
razor
<h3>Reusable Component</h3>
In this example:

ExampleComponent is a routable component that can be accessed via the URL /example.
ReusableComponent is a non-routable component that is used within ExampleComponent.
Summary
Routable Components: Have a @page directive, can be accessed via a URL, and are used for pages or views.
Non-Routable Components: Do not have a @page directive, cannot be accessed directly via a URL, and are used as reusable building blocks within other components.
Understanding the distinction between these two types of components helps in organizing your Blazor application effectively and utilizing components appropriately based on their intended use.
