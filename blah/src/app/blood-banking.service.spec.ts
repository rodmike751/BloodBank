import { TestBed } from '@angular/core/testing';

import { BloodBAnkingService } from './blood-banking.service';

describe('BloodBAnkingService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: BloodBAnkingService = TestBed.get(BloodBAnkingService);
    expect(service).toBeTruthy();
  });
});
