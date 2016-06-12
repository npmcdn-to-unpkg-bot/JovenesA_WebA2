// truncate.ts
import {PipeTransform, Pipe} from '@angular/core';

@Pipe({
  name: 'truncate'
})

export class TruncatePipe implements PipeTransform {
  transform(value: string, len: number) : string {
    return value.substring(0, 10);
  }
}
