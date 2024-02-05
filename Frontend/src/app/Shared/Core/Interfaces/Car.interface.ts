export interface Car {
    id: string;
    colour: string;
    make: string;
    model: string;
    registration: string;
    dailyRate: number;
    rentedOut: boolean;
    mileage: number;
    serviceMileage: number; // Updated to match Swagger
}