import {atomWithLazy, atomWithObservable} from "jotai/utils";
import {interval} from "rxjs";
import {map} from "rxjs/operators";

// Tạo Observable phát số đếm mỗi giây
const getObservable = () => interval(1000).pipe(map(count => `Đã đếm được: ${count}`));

// Tạo atom kết nối với Observable
export const timeAtom = atomWithObservable(getObservable);

export const countAtom = atomWithLazy(() => {
	console.log("💞💞💞💞💞 atom initialized"); // chỉ log khi useAtom được gọi lần đầu
	return 100; // tính toán nặng ở đây cũng được
});
