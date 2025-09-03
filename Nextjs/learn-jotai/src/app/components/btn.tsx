"use client";
import {useAtom} from "jotai";
import {counter} from "../page";

export default function BTN() {
	const [count, setCounter] = useAtom(counter);
	const onClick = () => setCounter(prev => prev + 1);
	return (
		<div className="flex flex-col items-center justify-center min-h-screen">
			<h1>{count}</h1>
			<button
				className="px-6 py-2 mt-4 bg-blue-600 text-white rounded-lg shadow hover:bg-blue-700 transition-colors duration-200"
				onClick={onClick}>
				Click
			</button>
		</div>
	);
}
