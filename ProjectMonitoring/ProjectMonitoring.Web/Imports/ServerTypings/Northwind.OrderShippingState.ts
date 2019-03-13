namespace ProjectMonitoring.Northwind {
    export enum OrderShippingState {
        NotShipped = 0,
        Shipped = 1
    }
    Serenity.Decorators.registerEnumType(OrderShippingState, 'ProjectMonitoring.Northwind.OrderShippingState', 'Northwind.OrderShippingState');
}

