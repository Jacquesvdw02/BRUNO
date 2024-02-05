export interface Car {
    colour: string;
    dailyRate: number;
    id: string;
    make: string;
    mileage: number;
    model: string;
    registration: string;
    rentedOut: boolean;
    serviceMileage: number; // Updated to match Swagger
}