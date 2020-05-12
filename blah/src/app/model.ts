export interface Region {
    id?: number;
    name: string;
    banks: number;
}

export interface Banks {
    id?: number;
    name: string;
    phone: string;
    location: string,
    regionId: number,
}

export interface Donors {
    id?: number;
    name: string;
    dateofbirth: any;
    sex: string;
    phone: number;
    bloodtype: any;
}

export interface ReturnObject {
    Msg: string;
    Status: boolean;
    Total: number;
    Data: any;
}