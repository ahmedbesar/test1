import { TestBed } from '@angular/core/testing';
import { test1Service } from './services/test1.service';
import { RestService } from '@abp/ng.core';

describe('test1Service', () => {
  let service: test1Service;
  const mockRestService = jasmine.createSpyObj('RestService', ['request']);
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: RestService,
          useValue: mockRestService,
        },
      ],
    });
    service = TestBed.inject(test1Service);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
