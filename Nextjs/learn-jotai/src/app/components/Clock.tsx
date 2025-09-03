"use client";

import {timeAtom} from "@/lib/tooh";
import {useAtomValue} from "jotai";

export default function Clock() {
	const time = useAtomValue(timeAtom);

	return <div>{time}</div>;
}
