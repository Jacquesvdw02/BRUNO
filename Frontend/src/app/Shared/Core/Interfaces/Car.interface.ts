export interface Car {
    colour: string;
    dailyRate: number;
    id: string;
    make: string;
    mileage: number;
    model: string;
    brand: string;
    year: number;
    transmission: string;
    fuelType: 'Petrol' | 'Gasoline' | 'Electric' | 'Hybrid';
    engineSize: number;
    bodyStyle: string;
    driveTrain: string;
    datePurchased: Date;
    registration: string;
    rentedOut: boolean;
    serviceMileage: number; // Updated to match Swagger
}