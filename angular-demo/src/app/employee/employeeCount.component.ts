import { Component } from '@angular/core';

@Component({
    selector: 'employee-count',
    templateUrl: '../employee/employeeCount.component.html',
    styleUrls: ['../employee/employeeCount.component.css']
})
export class EmployeeCountComponent {
    all: number = 10;
    male: number = 5;
    female: number = 5;
}