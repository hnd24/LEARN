"use client";
import {atom, useAtom} from "jotai";
import {atomWithDefault, RESET, useResetAtom} from "jotai/utils";
import Clock from "./components/Clock";

const count1Atom = atom(1);
const count2Atom = atomWithDefault(get => get(count1Atom) * 2);

export default function Page() {
	const [count1, setCount1] = useAtom(count1Atom);
	const [count2, setCount2] = useAtom(count2Atom);
	const resetCount2 = useResetAtom(count2Atom);

	return (
		<>
			<Clock />
			<div className="flex flex-col gap-4">
				<div>
					count1: {count1}, count2: {count2}
				</div>
				<button onClick={() => setCount1(c => c + 1)}>increment count1</button>
				<button onClick={() => setCount2(c => c + 1)}>increment count2</button>
				<button onClick={() => resetCount2()}>Reset with useResetAtom</button>
				<button onClick={() => setCount2(RESET)}>Reset with RESET const</button>
			</div>
		</>
	);
}
